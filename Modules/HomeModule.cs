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

        List<string> countResultData = new List<string>();
        countResultData.Add(Request.Form["inputSentence"]);
        countResultData.Add(Request.Form["inputWord"]);
        countResultData.Add(result);

        return View ["result.cshtml", countResultData];
      };
    }
  }
}
