using System;
using System.Collections.Generic;
namespace PlaylistManager;

public class Playlist
{
    private LinkedList<string> playlist = new LinkedList<string>();
    public int addSong(string songId)
    {
        if(playlist.Contains(songId))
        {
            return 0;
        }
        LinkedListNode<string> node=playlist.AddLast(songId);
        return 1;

    }
    public int removeSong(string songId)
    {
        if(!playlist.Contains(songId))
        {
            return 0;
        }
        playlist.Remove(songId);
        return 1;
    }
    public int moveToTop(string songId)
    {
        if(!playlist.Contains(songId))
        {
            return 0;
        }
        playlist.Remove(songId);
        playlist.AddFirst(songId);
        return 0;
    }
    public string getPlaylistOrder()
    {
         if(playlist.Count==0)
        {
            return "Empty Playlist";
        }
        
        return string.Join(" ",playlist);
    }
    public int processCommands(int N)
    {
        List<string> songList=new List<string>();
        
        for(int i=0;i<N;i++)
        {
            string input=Console.ReadLine();
            string[] parts=input.Split(" ");
            
            switch(parts[0])
            {
                case "ADD":
                    {
                        addSong(parts[1]);
                        break;
                    }
                case "REMOVE":
                    {
                        removeSong(parts[1]);
                        break;
                    }
                case "TOP":
                    {
                        moveToTop(parts[1]);
                        break;
                    }
                case "PRINT":
                    {
                       
                        songList.Add(getPlaylistOrder());
                        break;
                    }
            }
        }
        foreach(var item in songList)
        {
            System.Console.WriteLine(item);
        }
        return 1;
    }
    
}
