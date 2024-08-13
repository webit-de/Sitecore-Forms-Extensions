using System.Web;

namespace Feature.FormsExtensions.ValueProviderConditions
{
  public class ValueProviderConditionsContext
  {
    private const string ValueProviderConditionsMetKey = "ValueProviderConditionsMet";

    public static bool ValueProviderConditionsMet
    {
      get
      {
        if (HttpContext.Current?.Items == null)
          return false;

        if (HttpContext.Current.Items.Contains(ValueProviderConditionsMetKey))
        {
          return (bool)HttpContext.Current.Items[ValueProviderConditionsMetKey];
        }

        return false;
      }
      set
      {
        if (HttpContext.Current?.Items == null)
          return;

        HttpContext.Current.Items[ValueProviderConditionsMetKey] = value;
      }
    }
  }
}