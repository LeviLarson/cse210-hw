using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nNo entries to display.\n");
            return;
        }

        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine($"Entry {i + 1}:");
            entries[i].Display();
        }
    }

    public void SaveToFile(string filename)
    {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    outputFile.WriteLine(entry.ToFileString());
                }
            }
            Console.WriteLine("\nJournal saved successfully.\n");
    }

    public void LoadFromFile(string filename)
    {
            entries.Clear();
            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                entries.Add(Entry.FromFileString(line));
            }
            Console.WriteLine("\nJournal loaded successfully.\n");
            DisplayEntries();
        }
    }
