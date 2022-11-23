using System.Text.RegularExpressions;

namespace RoutingExample.CustomConstraints
{
    public class MonthsCustomConstraint : IRouteConstraint
    {
        // Eg: sales-report/2020/apr
        public bool Match(HttpContext? httpContext,
            IRouter? route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            // Check whether the value exists
            // routeKey = month
            if (values.ContainsKey(routeKey))
            {
                // Not a match
                return false;
            }

            Regex regex = new Regex("^(apr|jul|oct|jan)$");
            string? monthValue = Convert.ToString(values[routeKey]);

            if (regex.IsMatch(monthValue))
            {
                // It's a match
                return true;
            }
            else
            {
                // Not a match
                return false;
            }
        }
    }
}
