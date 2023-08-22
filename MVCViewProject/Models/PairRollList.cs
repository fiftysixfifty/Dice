using System.Text;

namespace MVCViewProject.Models;

internal class PairRollList: System.Collections.Generic.List<PairRoll>
{
	internal PairRollList(int capacity): base(capacity: capacity) {}

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder(capacity: this.Count);

        foreach (PairRoll pairRoll in this)
            stringBuilder.AppendLine(value: pairRoll.ToString());

        return stringBuilder.ToString();
    }
}