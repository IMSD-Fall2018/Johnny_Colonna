For my project I would like to take the data from Spotify's API. Looking through the data that is returned, there are many different pieces of data you can pull from a single artist or band. You can pull different statistics like bands that are related to them, the genre that they are, or even the popularity out of 100 that they hold on Spotify. For this project i want to have the user put in a Spotify ID number (Which represents the different artists or bands) and i want it to show in the game window the popularity of the band, represented by spheres equal to how popular they are.

I will need to rewrite a spawner script that instantiates spheres equal to the popularity. I will have to also learn how to string through and access the popularity, because a lot of data is returned at one time.

Output into the browser:
{
  "external_urls": {
    "spotify": "https://open.spotify.com/artist/12Chz98pHFMPJEknJQMWvI"
  },
  "followers": {
    "href": null,
    "total": 4379006
  },
  "genres": [
    "modern rock",
    "permanent wave",
    "piano rock",
    "post-grunge",
    "rock"
  ],
  "href": "https://api.spotify.com/v1/artists/12Chz98pHFMPJEknJQMWvI",
  "id": "12Chz98pHFMPJEknJQMWvI",
  "images": [
    {
      "height": 640,
      "url": "https://i.scdn.co/image/12450535621500d6e519275f2c52d49c00a0168f",
      "width": 640
    },
    {
      "height": 320,
      "url": "https://i.scdn.co/image/17f00ec7613d733f2dd88de8f2c1628ea5f9adde",
      "width": 320
    },
    {
      "height": 160,
      "url": "https://i.scdn.co/image/2da69b7920c065afc835124c4786025820adab8c",
      "width": 160
    }
  ],
  "name": "Muse",
  "popularity": 82,
  "type": "artist",
  "uri": "spotify:artist:12Chz98pHFMPJEknJQMWvI"
}
