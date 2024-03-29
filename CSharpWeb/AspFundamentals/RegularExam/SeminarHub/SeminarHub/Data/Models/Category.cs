﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SeminarHub.Data.Models
{
    public class Category
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(DataConstants.CategoryNameMaxLenght)]
        [Comment("Seminar category name")]
        public string Name { get; set; } = string.Empty;

		public ICollection<Seminar> Seminars { get; set; } = new List<Seminar>();
	}
}