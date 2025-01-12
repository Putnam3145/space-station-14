using Content.Shared.Construction;
using JetBrains.Annotations;
using Robust.Shared.GameObjects;
using Robust.Shared.Serialization.Manager.Attributes;
using System.Threading.Tasks;
using Content.Server.Destructible;

namespace Content.Server.Construction.Completions
{
    [UsedImplicitly]
    [DataDefinition]
    public sealed class DestroyEntity : IGraphAction
    {
        public void PerformAction(EntityUid uid, EntityUid? userUid, IEntityManager entityManager)
        {
            entityManager.EntitySysManager.GetEntitySystem<DestructibleSystem>().DestroyEntity(uid);
        }
    }
}
