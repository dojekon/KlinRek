namespace Klinrek.Class {
    public class ClinicalRecomendation { 
        public string ICD {get; set;} = string.Empty;
        public string ICDName {get; set;} = string.Empty;
        public List<Guidance>? Guidance {get; set;}
        public ClinicalRecomendation(string icd, string ICDName, List<Guidance>? guidance) {
            this.ICD = icd;
            this.ICDName = ICDName;
            this.Guidance = guidance;
        }
    }

    public class Guidance {
        public string Code {get; set;} = string.Empty;
        public string Name {get; set;} = string.Empty;
        public string FileName {get; set;} = string.Empty;
        public Guidance(string code, string name, string fileName) {
            this.Code = code;
            this.Name = name;
            this.FileName = fileName;
        }
    }
}