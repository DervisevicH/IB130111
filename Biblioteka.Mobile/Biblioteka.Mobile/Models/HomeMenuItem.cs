﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,        
        Rezervacija,
        Clanarine,
        Profil,
        Odjava,
        Obavijesti
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
