using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenRA.Activities;
using OpenRA.Mods.Common.Activities;
using OpenRA.Mods.Common.Pathfinder;
using OpenRA.Mods.Common.Orders;
using OpenRA.Primitives;
using OpenRA.Support;
using OpenRA.Traits;
using OpenRA.Mods.Common.Traits;

namespace OpenRA.Mods.CustomFormations
{
	class CustomFormationsTest : IResolveOrder, IOrderVoice
	{
		string IOrderVoice.VoicePhraseForOrder(Actor self, Order order)
		{
			return "Action";
			//if (!Info.MoveIntoShroud && order.Target.Type != TargetType.Invalid)
			//{
			//	var cell = self.World.Map.CellContaining(order.Target.CenterPosition);
			//	if (!self.Owner.Shroud.IsExplored(cell))
			//		return null;
			//}

			//if (order.OrderString == "AttackMove" || order.OrderString == "AssaultMove")
			//	return Info.Voice;

			//return null;
		}

		public void ResolveOrder(Actor self, Order order)
		{
			//if (order.OrderString == "AttackMove" || order.OrderString == "AssaultMove")
			//{
			//	if (!order.Target.IsValidFor(self))
			//		return;

			//	var cell = self.World.Map.Clamp(self.World.Map.CellContaining(order.Target.CenterPosition));
			//	if (!Info.MoveIntoShroud && !self.Owner.Shroud.IsExplored(cell))
			//		return;

			//	var targetLocation = move.NearestMoveableCell(cell);
			//	var assaultMoving = order.OrderString == "AssaultMove";

			//	// TODO: this should scale with unit selection group size.
			//	self.QueueActivity(order.Queued, new AttackMoveActivity(self, () => move.MoveTo(targetLocation, 8, targetLineColor: Info.TargetLineColor), assaultMoving));
			//	self.ShowTargetLines();
			//}
		}
	}

	//class CustomFormations2AttackMove
	//{
	//}
}
