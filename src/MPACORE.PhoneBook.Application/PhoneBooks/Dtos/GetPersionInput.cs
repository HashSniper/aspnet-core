using Abp.Runtime.Validation;
using MPACORE.PhoneBook.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MPACORE.PhoneBook.PhoneBooks.Dtos
{
    public class GetPersionInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public void Normalize()
        {
            if(string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

        public string FilterText { get; set; }
    }
}
