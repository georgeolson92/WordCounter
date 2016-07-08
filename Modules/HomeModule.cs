using Nancy;
using WordCounter.Objects;
using System.Collections.Generic;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View ["index.cshtml"];
      };
      Post["/result"] = _ => {
        RepeatCounter repeatCounter = new RepeatCounter();
        string result = repeatCounter.CountRepeats(Request.Form["inputWord"], Request.Form["inputSentence"]);
        return View ["result.cshtml", result];
      };
    }
  }
}
