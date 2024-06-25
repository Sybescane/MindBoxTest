using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox2.Model
{
    /// <summary>
	/// Базовый класс сущности (с идентификатором-первичным ключом)
	/// </summary>
	public abstract class EntityBase
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public Guid Id { get; set; }
    }
}
