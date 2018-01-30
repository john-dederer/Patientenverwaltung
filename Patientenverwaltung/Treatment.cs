using System;

namespace Patientenverwaltung
{
    [Serializable]
    public class Treatment : Model
    {
        public string Key { get; }
        public DateTime Date { get; set; }
        public String Description { get; set; }
        public String Other { get; set; }

        public Treatment()
        {
            Key = $@"{Date}|{Description}|{Other}";
        }

        protected bool Equals(Treatment other)
        {
            return Key == other.Key;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Treatment)obj);
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }

        public override string ToString()
        {
            return $@"{Date}|{Description}|{Other}";
        }
    }

    public static class TreatmentCounter
    {
        public static int Id;
    }
}
