using System;

namespace AxceligentTest
{
    public class Humanoid
    {
        public string Skills { get; set; }
        public Humanoid()
        {
            Skills = "no skill is defined";
        }
        public Humanoid(Dancing dancing)
        {
            dancing = new Dancing();
            Skills = dancing.DancingSkill;
        }
        public Humanoid(Cooking cooking)
        {
            cooking = new Cooking();
            Skills = cooking.CookingSkill;
        }
        public string ShowSkill()
        {
            return Skills;
        }
    }
    public class Dancing : Humanoid
    {
        public string DancingSkill { get; set; }
        public Dancing()
        {
            DancingSkill = "dancing";
        }
    }
    public class Cooking : Humanoid
    {
        public string CookingSkill { get; set; }
        public Cooking()
        {
            CookingSkill = "cooking";
        }
    }
}