using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; } //общее кол-во книг
        public int ItemsPerPage { get; set; } //кол-во книг на странице
        public int CurrentPage { get; set; } //номер текущей страницы

        public int TotalPages                //общее кол-во страниц
        {
            get { return (int) Math.Ceiling((decimal) TotalItems/ItemsPerPage); }
        }
    }
}