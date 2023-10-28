using System;
using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.VideoCard;

public class VideoCardFactory : IFactory<VideoCard>
{
    private readonly ICollection<VideoCard> _videoCardList;

    public VideoCardFactory(ICollection<VideoCard> videoCardList)
    {
        _videoCardList = videoCardList;
    }

    public VideoCard CreateByName(string name)
    {
        VideoCard videoCard =
            _videoCardList.FirstOrDefault(videoCard =>
                videoCard.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ??
            throw new ArgumentException("Wrong video card name");

        return videoCard.Clone();
    }
}