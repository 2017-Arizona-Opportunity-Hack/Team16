# -*- coding: utf-8 -*-
"""
Created on Sat Oct 21 16:20:05 2017

@author: Zijie Yuan
"""
import pandas
from difflib import SequenceMatcher


def similar(a, b):
    return SequenceMatcher(None, a, b).ratio()

if __name__ == '__main__':
    schools_file = input("Please input the file path for Standard School Names: ")
    new_data_file = input("Please input the file path for New Events (multiple sheets in one excel): ")
    save_to_path = input("Please input the path you would like to save the organized file: ")
 #   school_file = 'C:/Users/Zijie Yuan/Desktop/school address 2016.xlsx'
 #   new_data_file = 'C:/Users/Zijie Yuan/Desktop/2017 Programs & Participants.xlsx'
 #   save_to_path = 'C:/Users/Zijie Yuan/Desktop/SchoolNameStd.xlsx', engine='xlsxwriter'
    schools = pandas.read_excel(schools_file)
    new_data = pandas.ExcelFile(new_data_file)
    new_data_i = new_data.sheet_names
    std_school_name = schools['Name']
    
    writer = pandas.ExcelWriter(save_to_path)
    workbook = writer.book
    format1 = workbook.add_format({'bg_color':'#C6EFCE'}) # green
    format2 = workbook.add_format({'bg_color':'#FFC7CE'}) # red
    
    for st in range(len(new_data_i)):
        new = new_data.parse(new_data_i[st])
        fld_score = [similar('School Name',school_name) for school_name in new.columns]
        max_score = max(fld_score)
        lst_g = []
        lst_r = []
        if max_score > 0.9:
            idx_school_name = fld_score.index(max_score)
            field = new.columns[idx_school_name]
            new_data_school_name = new[field]
            for i in range(len(new_data_school_name)):
                if not pandas.isnull(new_data_school_name[i]):
                    sim_score = [similar(str.upper(new_data_school_name[i]),str.upper(std)) for std in std_school_name]
                    max_sim_score = max(sim_score)
                    idx = sim_score.index(max_sim_score)
                    # new_data_school_name[i] = std_school_name[idx]
                    if max_sim_score == 1.0:
                        pass
                    elif max_sim_score > 0.9 and max_sim_score < 1.0:
                        # save index for highlight (green)
                        lst_g.append(i+1)
                        new_data_school_name[i] = std_school_name[idx]
                    else:
                        # save index for highlight (red)
                        lst_r.append(i+1)

        # export new_data_school_name to a new file
        new.to_excel(writer, sheet_name=new_data_i[st],index=False)
        worksheet = writer.sheets[new_data_i[st]]
        # Highlight for different confidence level
        for i in lst_g:
            worksheet.conditional_format(i,idx_school_name,i,idx_school_name,{'type':'no_blanks',
                                                                              'format':format1})
        for i in lst_r:
            worksheet.conditional_format(i,idx_school_name,i,idx_school_name,{'type':'no_blanks',
                                                                              'format':format2})
        
    writer.save()
