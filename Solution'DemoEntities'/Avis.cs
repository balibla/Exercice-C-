//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solution_DemoEntities_
{
    using System;
    using System.Collections.Generic;
    
    public partial class Avis
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public double Note { get; set; }
        public int IdFormation { get; set; }
        public System.DateTime DateAvis { get; set; }
        public string UserId { get; set; }
    
        public virtual Formation Formation { get; set; }
    }
}
