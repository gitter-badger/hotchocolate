using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prometheus.Resolvers
{
    public delegate Task<object> FieldResolverDelegate(
        IResolverContext context,
        CancellationToken cancellationToken);
}