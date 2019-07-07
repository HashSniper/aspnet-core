using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPACORE.PhoneBook.PhoneBooks.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MPACORE.PhoneBook.PhoneBooks
{
    public interface IPersonAppService: IApplicationService
    {
        /// <summary>
        /// 获取用户的相关信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPeronAsync(GetPersionInput input);

        /// <summary>
        /// 根据id获取用户相关信息
        /// </summary>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input);

        /// <summary>
        /// 新增或者更改联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input);

        /// <summary>
        /// 删除联系人
        /// </summary>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto input);
    }
}
