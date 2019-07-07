using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACORE.PhoneBook.PhoneBooks.Persons
{
    public class Person : FullAuditedEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(PhoneBookConsts.MaxNameLenghth)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [EmailAddress]
        [MaxLength(PhoneBookConsts.MaxEmailLength)]
        public string EmailAdress { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        [MaxLength(PhoneBookConsts.MaxAdressLength)]
        public string Adress { get; set; }
    }
}
