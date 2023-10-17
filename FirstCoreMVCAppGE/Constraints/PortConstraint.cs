namespace FirstCoreMVCAppGE.Constraints
{
    public class PortConstraint : IRouteConstraint
    {
        bool IRouteConstraint.Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext?.Connection.LocalPort == 7087;
        }
    }
}
