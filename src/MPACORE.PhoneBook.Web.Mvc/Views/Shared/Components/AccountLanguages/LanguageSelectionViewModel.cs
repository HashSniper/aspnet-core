﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Abp.Localization;

namespace MPACORE.PhoneBook.Web.Views.Shared.Components.AccountLanguages
{
    public class LanguageSelectionViewModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public IReadOnlyList<LanguageInfo> Languages { get; set; }

        public PathString CurrentUrl { get; set; }
    }
}