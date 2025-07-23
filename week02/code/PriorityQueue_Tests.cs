using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three elements with different priorities (Bryan: 1, Manuel: 3, Lorena: 2).
    // Expected Result: Dequeue should return "Manuel", as it has the highest priority (3).
    // Defect(s) Found: The method returns the correct element with the highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bryan", 1);
        priorityQueue.Enqueue("Manuel", 3);
        priorityQueue.Enqueue("Lorena", 2);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Manuel", result);
    }

    [TestMethod]
    // Scenario:If multiple items have the same highest priority,
    // the one closest to the front of the queue (i.e., the earliest inserted) is removed.
    // This ensures fairness by honoring insertion order in case of priority ties.
    // Expected Result: Dequeue should return "Howard", as it has the highest priority(9)
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Jose", 3);
        priorityQueue.Enqueue("Manolo", 1);
        priorityQueue.Enqueue("Howard", 9);
        priorityQueue.Enqueue("Stephen", 6);
        priorityQueue.Enqueue("Edward", 9);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Howard", result);
    }

    // Add more test cases as needed below.


    [TestMethod]
    // Scenario: Adding a new item using the Enqueue function
    // Expected Result:Josue 
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Josue", 5);
        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Josue", result);
    }

    [TestMethod]
    // Scenario: Checking if the program throws error when trying to remove values from an empty queue.
    // Expected Result: The queue is empty.
    // Defect(s) Found: 
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected exception was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }


    }

}