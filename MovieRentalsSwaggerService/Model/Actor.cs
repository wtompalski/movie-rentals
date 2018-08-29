using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentals.Model
{
    /// <summary>
    /// Representation of an actor in database.
    /// </summary>
    public class Actor
    {
        /// <summary>
        /// Id of an actor.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTimeOffset DateOfBirth { get; set; }

        /// <summary>
        /// Gender of an actor.
        /// </summary>
        [Required]
        public Gender Gender { get; set; }
    }
}
