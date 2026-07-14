# Graph Algorithms Visualizer

A desktop application for creating, displaying, and analyzing undirected graphs using the Breadth-First Search algorithm.

The project was developed in C# with Windows Forms and demonstrates the practical use of graph data structures, adjacency lists, event-driven programming, and BFS traversal.

## Features

- Create graph vertices with custom names
- Add undirected edges between existing vertices
- Prevent duplicate vertices
- Prevent duplicate edges
- Prevent self-loops
- Display the graph visually
- Automatically place vertices on the drawing panel
- Run Breadth-First Search from a selected starting vertex
- Display the BFS traversal order
- View graph statistics:
  - number of vertices
  - number of edges
  - adjacency list
- Clear the graph and reset the interface
- Validate user input and display error messages

## Technologies

- C#
- .NET Framework 4.8
- Windows Forms
- Object-Oriented Programming
- Graph Theory
- Breadth-First Search
- Adjacency List
- Visual Studio

## How It Works

The graph is represented by an adjacency list:

```csharp
Dictionary<string, List<string>>
```

Each key represents a vertex, while its associated list contains all neighboring vertices.

Edges are stored in both directions, which means the application works with an undirected graph.

Example:

```text
A: B, C
B: A, D
C: A
D: B
```

## Breadth-First Search

Breadth-First Search explores graph vertices level by level.

The algorithm uses:

- a queue to process vertices
- a `HashSet` to track visited vertices
- an adjacency list to retrieve neighboring vertices

Example traversal:

```text
A -> B -> C -> D
```

The traversal begins from a user-selected starting vertex and continues until all reachable vertices have been visited.

## Application Workflow

1. Enter a vertex name.
2. Click the button to add the vertex.
3. Repeat the process for additional vertices.
4. Enter the names of two existing vertices.
5. Add an edge between them.
6. Enter the starting vertex for BFS.
7. Run the algorithm.
8. View the traversal order in the results list.

## Input Validation

The application checks for:

- empty vertex names
- duplicate vertices
- nonexistent vertices
- duplicate edges
- self-loops
- missing BFS starting vertex
- invalid BFS starting vertex

Invalid operations are rejected and explained through message boxes.

## Project Structure

```text
Graph-Algorithms-Visualizer
│
├── GraphVisualizer.sln
├── README.md
│
└── GraphVisualizer
    ├── App.config
    ├── BFSAlgorithm.cs
    ├── Graph.cs
    ├── GraphNode.cs
    ├── GraphVisualizer.csproj
    ├── MainForm.cs
    ├── MainForm.Designer.cs
    ├── MainForm.resx
    ├── Program.cs
    │
    └── Properties
        ├── AssemblyInfo.cs
        ├── Resources.Designer.cs
        ├── Resources.resx
        ├── Settings.Designer.cs
        └── Settings.settings
```

## Main Components

### `Graph.cs`

Responsible for storing and managing graph data.

Main operations:

- adding vertices
- adding edges
- checking whether a vertex exists
- retrieving neighboring vertices
- counting vertices and edges
- generating the adjacency list
- clearing the graph

### `BFSAlgorithm.cs`

Contains the Breadth-First Search implementation.

The class:

- accepts a graph and starting vertex
- processes vertices with a queue
- tracks visited vertices
- returns the traversal order

### `GraphNode.cs`

Represents a visual graph node.

Stores:

- vertex name
- X coordinate
- Y coordinate

### `MainForm.cs`

Contains the main user interface logic.

Responsible for:

- handling button clicks
- validating input
- drawing vertices and edges
- displaying messages
- running BFS
- showing graph information
- clearing the application state

### `MainForm.Designer.cs`

Contains automatically generated Windows Forms interface code.

## Requirements

- Windows 10 or Windows 11
- Visual Studio 2022
- .NET Framework 4.8
- Windows Forms development workload

## Installation

Clone the repository:

```bash
git clone https://github.com/vsborysovfitm24-png/Graph-Algorithms-Visualizer.git
```

Open the project directory:

```bash
cd Graph-Algorithms-Visualizer
```

Open the solution file:

```text
GraphVisualizer.sln
```

Then build and run the project in Visual Studio.

## Running the Project

In Visual Studio:

1. Open `GraphVisualizer.sln`.
2. Select `Build`.
3. Click `Build Solution`.
4. Press `F5` or click `Start`.

## Screenshots

Create a folder named:

```text
screenshots
```

Add screenshots of the application there.

Recommended images:

```text
screenshots/main-window.png
screenshots/graph-created.png
screenshots/bfs-result.png
screenshots/graph-information.png
```

Then add them to this README using:

```markdown
## Screenshots

### Main Window

![Main Window](screenshots/main-window.png)

### Graph Visualization

![Graph Visualization](screenshots/graph-created.png)

### BFS Result

![BFS Result](screenshots/bfs-result.png)

### Graph Information

![Graph Information](screenshots/graph-information.png)
```

## Possible Future Improvements

- Add vertex deletion
- Add edge deletion
- Allow users to move vertices manually
- Add Depth-First Search
- Highlight visited vertices during traversal
- Animate BFS execution
- Support weighted graphs
- Implement Dijkstra's algorithm
- Save and load graphs
- Export graph images
- Add dark mode
- Improve automatic vertex positioning
- Add unit tests

## What I Practiced

This project helped me practice:

- C# development
- Windows Forms
- object-oriented programming
- graph data structures
- adjacency lists
- BFS implementation
- collections such as `Dictionary`, `List`, `Queue`, and `HashSet`
- event-driven programming
- input validation
- graphical rendering
- project structure and Git usage

## Author

**Vladyslav Borysov**

Cybersecurity student and Junior Duty Engineer at GMS.

Interests:

- Cybersecurity
- Security monitoring
- Incident response
- Network security
- C# development

GitHub:

```text
https://github.com/vsborysovfitm24-png
```
