using System;

namespace Cassantic.Core.Domains
{
    public partial class ActionLog : IBaseEntity
    {
        #region Properties

        public  int ActivityLogTypeId { get; set; }

        public  int CustomerId { get; set; }

        public  string Comment { get; set; }

        #endregion

        #region Navigation Properties
        public virtual ActionLogType ActionLogType { get; set; }
        public virtual Users Customer { get; set; }

        #endregion
    }
}
