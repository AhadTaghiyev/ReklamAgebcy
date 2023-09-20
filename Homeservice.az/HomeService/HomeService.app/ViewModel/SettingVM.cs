using HomeService.core.Models;
using HomeService.service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeService.app.ViewModel
{
    public class SettingVM
    {
        public SettingPostDto PostDto { get; set; }
        public SettingGetDto GetDto { get; set; }
       
    }
}
