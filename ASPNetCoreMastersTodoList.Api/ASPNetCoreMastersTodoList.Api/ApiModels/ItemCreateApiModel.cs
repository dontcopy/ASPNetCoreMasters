﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreMastersTodoList.Api.ApiModels
{
    public class ItemCreateApiModel
    {
        [StringLength(128, MinimumLength = 1)]
        [Required]
        public string Text { get; set; }
    }
}
