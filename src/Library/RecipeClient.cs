using System.Globalization;
using System;

namespace Full_GRASP_And_SOLID
{
    public class RecipeClient : TimerClient
    {
        public Recipe Recipe { get; set; }
        public RecipeClient(Recipe recipe)
        {
            this.Recipe = recipe;
        }

        public void RegisterTimer()
        {
            CountdownTimer timer = new CountdownTimer();
            timer.Register(this.Recipe.GetCookTime(), this);
        }
        public void TimeOut()
        {
            this.Recipe.GetCooked();
        }
    }
}