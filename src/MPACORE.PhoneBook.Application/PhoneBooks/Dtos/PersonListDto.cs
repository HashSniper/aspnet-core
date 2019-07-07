using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MPACORE.PhoneBook.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACORE.PhoneBook.PhoneBooks.Dtos
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto: FullAuditedEntityDto
    {


        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string EmailAdress { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        public string Adress { get; set; }
    }
}
