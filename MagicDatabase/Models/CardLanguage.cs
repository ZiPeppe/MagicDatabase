﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MagicDatabase.Models
{
    [Table("CardLanguage")]
    public class CardLanguage
    {
        public int CardLanguageId { get; set; }
        public string CardLanguageName { get; set; }
    }
}
