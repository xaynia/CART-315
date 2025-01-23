# Process Journal

**Process Journal* "diary, reflection on the status of the project, references, images and anything else that captures the normal elements of design and development as it happens."

## Design Journal

1. **Week 1: Tiny Game**  
   After reflecting, and playing various inspiring Bitsy games, I have narrowed my focus to a Bitsy game. I like the dialogue, and simplistic art style. 

   The scene is at the shore. A raven sits there. An orca resides in the water. The characters journey is about finding guidance and comfort in nature at the shore, as they drift on their way to finding their purpose. 
   
   Rather than going to different rooms, the player walks along the beach in the same scene, collecting items along the beach. As the player collects various different items along the beach, the dialogue progresses, revealing the characters internal journey.

   Characters: 
   - Orca: Wise, mysterious. Knows the ancient, deep, mysterious wisdom of the ocean. Deep, like the ocean. The orca ocassionaly and majestically surfaces. Truly a sight to see when he surfaces, he spouts grand wisdom, before he returns to his pod.
   - Raven: the Trickster: May **act** as a guide. Sharp and confrontational in nature, in contrast with the orca. Vapid, like the air. The Raven croaks and caws, and flaps it's wings around.

   Items: 
   - Driftwood: May reveal objects, perhaps carvings, for the player to see. Maybe even symbolic of people.
   - Sea glass: Symbolizes transformation. Even from the roughest of seas, can bring a beautiful gem.
   - Shell: Triggers a childhood memory, about simpler times.
   - Fishing net: 


**Update: Changed Game: Ghost Tale**
After testing Bitsy, I felt it was too primitive (because of the 3 color limitation) and decided to switch over to pico-8—and I’m so glad I did! I started by designing a ghost and built a platformer around it. The learning curve was steep, but once I got the hang of the code, it became a blast to create. I ended up making a game about a ghost whose soul is restless, roaming around an area filled with graves. I added three trick graves with spike traps, detours, and tricky-to-reach platforms. At the very edge of the map is the ghost’s real grave, which marks the end of the game. Testing it was definitely the most fun part!

The biggest pit of the entire process happened when I used the selector tool to erase tiles and accidentally pressed “delete” with nothing selected. A huge chunk of tiles vanished in an instant. Note to self: always save immediately when I’m happy with my progress!

I decided to purchase pico-8, and I’m so glad I learned it. Yes, the learning curve is steep, but NerdyTeachers on YouTube helped me a lot. I’ll definitely be making more games in pico-8, and I had so much fun designing this one! If I could go back in time, I’d have started earlier, because the deeper I got into testing, the more features I wanted to add, and suddenly there wasn’t enough time. Overall, though, I’m very happy with how everything turned out!

I really enjoy platformer games. Some of my favourites are Super Mario Bros Wonder, and Super Mario 3D world. 

From testing the game these were the changes I had to implement:
- Adjusting the text which the draw function uses when you encounter the flagged graves (for the wrong grave, and the winning condition grave. The text was way off center and went off the edge of the screen. I fixed this with subtraction to the player.x and player.y variables.
- e.g: winning condition: found grave  
	if collide_map(player,"right",7) then
			print('may your soul\nrest in peace...\n   you won!',player.x-54,player.y-15)
- I added platforms to get back up the steep pit at the start of the game, as to not be stuck down there. I also made the platforms to get the next mountain trickier to get to to make it harder. I tested getting the "perfect" jump to one platform, where you just make it, and then copy and pasted and stamped the next 2 platforms, so the game wouldn't be too easy. I did this with spikes too, like with the false grave at the bottom.
- Testing the flags took some times. For example, the spikes would send you back to the start of the game. I ended up adding additional spikes and making some of the false graves trickier to get to with more traps and spikes which could send you back to the start.
- 

**Future Improvements:**
- Adding music to the game would be great. Adding characters such as NPC monsters which move around and damage you would be really fun too. Adding objects like coins would also be a really great addition. It would have been fun to add more details and features, and while I think there is always room for improvements, I am satisfied with baseline game. 





2. **Title:**  
   ...


