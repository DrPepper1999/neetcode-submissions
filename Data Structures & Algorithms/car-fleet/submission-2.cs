public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
         var feels = position
            .Zip(speed, (position, speed) => new Fleet(position, speed))
            .OrderByDescending(car => car.Position);
        
        var stack = new Stack<Fleet>();
        foreach (var feel in feels)
        {
            if (stack.Count == 0)
            {
                stack.Push(feel);
                continue;
            }

            var frontFeel = stack.Pop();
            if (feel.IsCatchesUp(frontFeel, target))
            {
                stack.Push(new Fleet(Math.Max(feel.Position, frontFeel.Position), Math.Min(feel.Speed, frontFeel.Speed)));
            }
            else
            {
                stack.Push(frontFeel);
                stack.Push(feel);
            }
        }

        return stack.Count;
    }

    record Fleet(int Position, int Speed)
{
    public bool IsCatchesUp(Fleet otherFleet, int target)
    {
        return CalcTimeToTarget(target) <= otherFleet.CalcTimeToTarget(target);
    }

    private double CalcTimeToTarget(int target)
    {
        return (double)(target - Position) / Speed;
    }
}
}
