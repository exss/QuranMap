﻿using Framework.Core.Domain.DomainModel;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace QMP.Domain.Core
{
    public class Dimension:Entity//, IHasAssociation<DimensionAssociation>
    {    
        public virtual string Name
        {
            get;
            set;
        }

        public virtual IList<DimensionAssociation> SubAssociations
        {
            get;
            set;
        }
        public virtual IList<DimensionAssociation> BaseAssociations
        {
            get;
            set;
        }
    }
}

