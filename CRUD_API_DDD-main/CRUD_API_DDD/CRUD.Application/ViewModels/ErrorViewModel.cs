﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Application.ViewModels
{
    public class ErrorViewModel
    {
        public List<string> Errors { get; set; }

        public ErrorViewModel(List<string> erros) => Errors = erros;
    }
}
