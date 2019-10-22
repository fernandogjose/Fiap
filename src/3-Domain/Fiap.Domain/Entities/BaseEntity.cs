using System;

namespace Fiap.Domain.Entities
{
    public class BaseEntity<T>
    {
        public int Id { get; set; }
        public int? IdUsuarioAlteracao { get; set; }
        public int? IdUsuarioCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public DateTime? DataCriacao { get; set; }

        #region Methods

        public override bool Equals(object obj)
        {
            var compareTo = obj as BaseEntity<T>;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907 + Id.GetHashCode());
        }

        public override string ToString()
        {
            return GetType().Name + "[Id = " + Id + "]";
        }

        #endregion

        #region Operators

        public static bool operator == (BaseEntity<T> a, BaseEntity<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator != (BaseEntity<T> a, BaseEntity<T> b)
        {
            return !(a == b);
        }

        #endregion
    }
}
