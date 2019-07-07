using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MPACORE.PhoneBook.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MPACORE.PhoneBook.PhoneBooks.PhoneNumbers
{
    public class PhoneNum :Entity<long>,IHasCreationTime
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [Required]
        [MaxLength(12)]
        public string Number { get; set; }

        /// <summary>
        ///类型
        /// </summary>
        PhoneType Type { get; set; }

        public int PersonId { get; set; }

        public Person Person { get; set; }
    }
}
