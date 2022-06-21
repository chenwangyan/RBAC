using Rbac.Entity;
using System;
using System.Collections.Generic;

namespace DTO
{
    public class MenuDTO
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string LinkUrl { get; set; }
        public  List<MenuDTO> children { get; set; }=new List<MenuDTO>();
    }
}
