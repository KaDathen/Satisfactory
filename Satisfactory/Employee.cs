//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Satisfactory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Supplies = new HashSet<Supplies>();
        }
    
        public int IDСотрудника { get; set; }
        public string ФИО { get; set; }
        public System.DateTime ДатаРождения { get; set; }
        public int ПаспортныеДанные { get; set; }
        public int БанковскиеРеквизиты { get; set; }
        public string СостояниеЗдоровья { get; set; }
        public bool НаличиеСемьи { get; set; }
        public string Специализация { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplies> Supplies { get; set; }
    }
}
