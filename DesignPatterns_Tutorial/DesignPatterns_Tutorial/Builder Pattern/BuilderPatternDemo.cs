using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Tutorial.Builder_Pattern
{
    public class BuilderPatternDemo:Demo
    {
        public override void Show()
        {
            var tea =TeaBuilder.PreapareTea().AddMilk().AddWater().AddTeaLeaf().AddSugar().Boil();
        }
    }
}
