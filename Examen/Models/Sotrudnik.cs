//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sotrudnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sotrudnik()
        {
            this.AdditionalDocuments = new HashSet<AdditionalDocuments>();
            this.doljnost = new HashSet<doljnost>();
            this.Experience = new HashSet<Experience>();
            this.Family = new HashSet<Family>();
            this.Obrazovanie = new HashSet<Obrazovanie>();
            this.Passport = new HashSet<Passport>();
            this.Otpusk = new HashSet<Otpusk>();
            this.Waruchet = new HashSet<Waruchet>();
        }
    
        public int ID { get; set; }
        public string lastname { get; set; }
        public string nam { get; set; }
        public string patronomic { get; set; }
        public string telefon { get; set; }
        public string adress { get; set; }
        public string mestorojdenia { get; set; }
        public Nullable<System.DateTime> datarojdeniya { get; set; }
        public string in_yaz { get; set; }
        public string grajdanstvo { get; set; }
        public string brak { get; set; }
        public string del { get; set; }
        public string uvolen { get; set; }
        public string mesto_rojd { get; set; }
        public string Pol { get; set; }
        public string Identitynomer { get; set; }
        public string OKIN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdditionalDocuments> AdditionalDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doljnost> doljnost { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Experience> Experience { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Family> Family { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obrazovanie> Obrazovanie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passport> Passport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Otpusk> Otpusk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Waruchet> Waruchet { get; set; }
    }
}