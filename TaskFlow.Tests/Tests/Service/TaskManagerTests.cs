using TaskFlow.Console;
using TaskFlow.Console.Service;

namespace TaskFlow.Tests.Tests.Service;

public class TaskManagerTests
{
    [Fact]
    public void AddTask_Should_Add_Task_When_Title_Is_Valid()
    {
        // Arrange
        var manager = new TaskManager();
        string title = "Estudar C# e .NET 10";

        // Act
        var task = manager.AddTask(title);

        // Assert
        Assert.NotNull(task);
        Assert.Equal(title, task.Title);
        Assert.False(task.IsCompleted);
        Assert.Single(manager.Tasks);
    }

    [Fact]
    public void AddTask_Should_Throw_Exception_When_Title_Is_Empty()
    {
        // Arrange
        var manager = new TaskManager();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => manager.AddTask("   "));
    }

    [Fact]
    public void GetById_Should_Return_Null_When_Task_Does_Not_Exist()
    {
        // Arrange
        var manager = new TaskManager();

        // Act
        var task = manager.GetById(Guid.NewGuid());

        // Assert
        Assert.Null(task);
    }

    [Fact]
    public void CompleteTask_Should_Return_False_When_Task_Does_Not_Exist()
    {
        // Arrange
        var manager = new TaskManager();
        var nonExistentId = Guid.NewGuid();

        // Act
        var result = manager.CompleteTask(nonExistentId);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CompleteTask_Should_Mark_Task_As_Completed_When_Task_Exists()
    {
        // Arrange
        var manager = new TaskManager();
        var task = manager.AddTask("Estudar XUnit");

        // Act
        var result = manager.CompleteTask(task.Id);

        // Assert
        Assert.True(result);
        Assert.True(task.IsCompleted);
    }

    [Fact]
    public void GetById_Should_Return_Task_When_Task_Exists()
    {
        // Arrange
        var manager = new TaskManager();
        var task = manager.AddTask("Aprender C# 10");

        // Act
        var foundTask = manager.GetById(task.Id);

        // Assert
        Assert.NotNull(foundTask);
        Assert.Equal(task.Id, foundTask.Id);
        Assert.Equal("Aprender C# 10", foundTask.Title);
    }
}
