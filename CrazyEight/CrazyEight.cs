using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CrazyEight
{
    public partial class CrazyEight : Form
    {
        List<Solution> _solutions;
        public CrazyEight()
        {
            InitializeComponent();
            buttonShowAll.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (Exception ex)
            {
                rtbResult.Text = ex.Message;
            }
        }
        private void Calculate()
        {
            // Retrieve input values
            int playerBase = int.Parse(playerBaseTextBox.Text);
            int opponentBase = int.Parse(opponentBaseTextBox.Text);
            List<int> playerShopItems = ParseInput(playerShopTextBox.Text);
            List<int> opponentShopItems = ParseInput(opponentShopTextBox.Text);

            // Run calculation
            List<Solution> solutions = FindEqualSums(playerBase, opponentBase, playerShopItems, opponentShopItems);

            // Display solutions
            if (solutions.Count > 0)
            {
                var bestSolution = solutions.OrderBy(s => s.TotalSum).First();
                rtbResult.Text = $"最佳方案: 我方购买 [{string.Join(", ", bestSolution.PlayerItems)}], " +
                                 $"对方购买 [{string.Join(", ", bestSolution.OpponentItems)}]\n" +
                                 $"最佳方案: 血量总数 = {bestSolution.TotalSum}\n" +
                                 $"发现解法: {solutions.Count}\n";

                _solutions = solutions;
                buttonShowAll.Visible = true;
            }
            else
            {
                rtbResult.Text = "无解.";
            }
        }

        private List<int> ParseInput(string input)
        {
            return input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
        }
        /// <summary>
        /// Find all possible solutions ， playerShopItems 最多用3个数字，最少一个不用；opponentShopItems 最多用3个数字，最少一个不用。给出所有可能结果。
        /// 
        /// </summary>
        /// <param name="playerBase"></param>
        /// <param name="opponentBase"></param>
        /// <param name="playerShopItems"></param>
        /// <param name="opponentShopItems"></param>
        /// <returns></returns>
        private List<Solution> FindEqualSums(int playerBase, int opponentBase, List<int> playerShopItems, List<int> opponentShopItems)
        {
            var solutions = new List<Solution>();

            // Get all possible combinations of 0 to 3 items from the playerShopItems
            var playerCombinations = GetCombinations(playerShopItems);
            // Get all possible combinations of 0 to 3 items from the opponentShopItems
            var opponentCombinations = GetCombinations(opponentShopItems);

            // Compare all combinations
            foreach (var playerItems in playerCombinations)
            {
                foreach (var opponentItems in opponentCombinations)
                {
                    int playerSum = playerBase + playerItems.Sum();
                    int opponentSum = opponentBase + opponentItems.Sum();

                    if (playerSum == opponentSum)
                    {
                        solutions.Add(new Solution(playerItems, opponentItems, playerSum));
                    }
                }
            }

            return solutions;
        }
        // Helper method to get all combinations of 0 to 3 items
        private static List<List<int>> GetCombinations(List<int> items)
        {
            var result = new List<List<int>>();

            // Use combinations of 0 to 3 items
            for (int i = 0; i <= Math.Min(3, items.Count); i++)
            {
                result.AddRange(GetCombinationsOfSize(items, i));
            }
            return result;
        }
        // Get combinations of a specific size
        private static IEnumerable<List<int>> GetCombinationsOfSize(List<int> items, int size)
        {
            if (size == 0) yield return new List<int>();
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    foreach (var combination in GetCombinationsOfSize(items.Skip(i + 1).ToList(), size - 1))
                    {
                        combination.Insert(0, items[i]);
                        yield return combination;
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            playerBaseTextBox.Text = "";
            playerShopTextBox.Text = "";

            opponentBaseTextBox.Text = "";
            opponentShopTextBox.Text = "";

            rtbResult.Text = "";
            buttonShowAll.Visible = false;
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            var solutions = _solutions;
            int i = 1;
            foreach (var solution in solutions)
            {
                rtbResult.Text += $"方案{i++,4}: 我方购买 [{string.Join(", ", solution.PlayerItems)}], " + $"对方购买 [{string.Join(", ", solution.OpponentItems)}]; 血量总数 = {solution.TotalSum}\n";
            }
        }
    }

    public class Solution
    {
        public List<int> PlayerItems { get; }
        public List<int> OpponentItems { get; }
        public int TotalSum { get; }

        public Solution(List<int> playerItems, List<int> opponentItems, int totalSum)
        {
            PlayerItems = playerItems;
            OpponentItems = opponentItems;
            TotalSum = totalSum;
        }
    }
}

