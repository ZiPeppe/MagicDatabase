﻿using System.ComponentModel.DataAnnotations.Schema;
namespace MagicDatabase.Models
{
    [Table("CardLanguage")]
    public class CardStatus
    {
        public int CardStatusId { get; set; }
        public string CardStatusName { get; set; }
    }
}
