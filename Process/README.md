# Process Journal

** Note for self:**
- Journal: diary, reflection on the status of the project, references, images and anything else that captures the normal elements of design and development as it happens."
- thoughts and reflections throughout the process of prototyping games (e.g.,discussing the design goals for the current idea, what you made to test those ideas, what your take away from the prototype was, and what you intend to accomplish next. 

## Design Journal

# Week 1-2: Tiny Game

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

**Inspiration**
I really enjoy platformer games. Some of my favourites are Super Mario Bros Wonder, and Super Mario 3D world. I think there may have been some subconscious inspiration from games like this.

**From testing the game, these were some changes I had to implement:**
- Adjusting the text which the draw function uses when you encounter the flagged graves (for the wrong grave, and the winning condition grave. The text was way off center and went off the edge of the screen. I fixed this with subtraction to the player.x and player.y variables.
- e.g: winning condition: found grave  
	if collide_map(player,"right",7) then
			print('may your soul\nrest in peace...\n   you won!',player.x-54,player.y-15)
- I added platforms to get back up the steep pit at the start of the game, as to not be stuck down there. I also made the platforms to get the next mountain trickier to get to to make it harder. I tested getting the "perfect" jump to one platform, where you just make it, and then copy and pasted and stamped the next 2 platforms, so the game wouldn't be too easy. I did this with spikes too, like with the false grave at the bottom.
- Testing the flags took some times. For example, the spikes would send you back to the start of the game. I ended up adding additional spikes and making some of the false graves trickier to get to with more traps and spikes which could send you back to the start.
- After a few playthroughs, I made various small tweaks, such as adding a tunnel to make it a little more interesting, adding flowers, increasing difficulty between platforms, adding more spikes to make the game more challenging.

**Future Improvements:**
- Adding music to the game would be great. Adding characters such as NPC monsters which move around and damage you would be really fun too. Adding objects like coins would also be a really great addition. It would have been fun to add more details and features, and while I think there is always room for improvements, I am satisfied with baseline game. 

**Notes about Testing Bitsy:**
- I really liked the dialogue and simplicity with Bitsy. I spent a decent amount of time trying to figure out how to use it, seeing if I could add more than 3 colors into the color palette with the code. After I decided 3 colors wouldn't work (and a youtuber who confirmed I should infact stop) for my idea I decided to try Pico-8. I felt like I had a solid plan with my original idea. It was supposed to be a relatively fast game but have impactful dialogue about changes in life. From the games I tested in Bitsy, my favourite part about them is how impactful they can be, from this perspective. 
- Favourite Bitsy Games I tested:
  
https://zenzoa.itch.io/wandering-home

https://le-onionboi.itch.io/spoons

https://lolabug.itch.io/no-longer-human

**Notes about Ghost Tale & Pico-8:**
- I felt like I needed a plan intially, and even though I went into Pico-8 with no plan, the funnest part about creating Ghost Tale was actually that I had absolutely no plan, and went into a state of flow, rather. I decided to watch a youtube video of someone who learned Pico-8 in a day and made a game, and mentioned NerdyTeachers https://nerdyteachers.com/Explain/Platformer/ platformer series which helped me. After brainstorming a few ideas about a character, I chose a cute ghost. As for the movement, the ghost would just bob. From there, I had alot of fun designing platforms with an aesthetic which would match the ghost theme. From there I had alot of fun figuring out how Pico-8 works, laying the tiles I created, and testing movement and interaction, etc. I started laying tiles, and put a pit at the start of the game. I realized quickly that when the ghost fell down the pit, the camera did not follow. This required adjusting the update functions player.x variable. Once this was fixed I had so much fun designing the world! I realized I would need a way to end the game however, so I thought a treasure chest could work intially. After thinking about it some more, I thought finding the ghosts gravestone would make a good plot, so I went with that idea. From here I started testing flags, and realized I would need to add a message when you interact with them, which I added in the _Draw function. Once I got this working I thought adding false gravestones would be fun too, so I designed the false gravestone with a different flag and placed 3 of those in the world too. After this I would keep implementing changes, running the game and testing it, and repeat, until I was happy with the finished product. Overall I am happy with the game, and was really happy I ended up using Pico-8, especially since using Lua ended up having some overlap with Javascript, so it helped me with getting some terms and concepts to long term memory.
- Camera e.g: 	
	cam_x=player.x-64+(player.w/2)
	if cam_x<map_start then
				cam_x=map_start
	end
	if cam_x>map_end-128 then
				cam_x=map_end-128
	end
	camera(cam_x,player.y-64)
end
- Gravestone Win condition Flag e.g:
  function _draw()
	cls()
	map(0,0)
	spr(player.sp,player.x,player.y,1,1,player.flp) 
	
	print('your soul wanders restlessly \n you must find your grave',124,54)
	print('press x to jump',30,82)


2. **Title:**  
   ...


# Week 3
Note: I emailed you about this week.

# Week 4
This week, I focused on setting up my development environment (Rider and Unity), organizing my GitHub repository, and diving into the [Unity Essentials](https://learn.unity.com/pathway/unity-essentials) pathway on Unity Learn. I logged **15 hours** of work (tracked via Toggl) which included:

- Installing and configuring Rider and Unity  
- Reviewing Unity basics through tutorials and reading documentation  
- Consolidating notes and references from the tutorials  
- Committing tutorial progress to GitHub under a new `Tutorials` folder  

These foundational steps have helped me feel more comfortable and confident using Unity. My next goal is to apply everything I’ve learned by starting a new prototype and brainstorming my own game ideas.

## What I Accomplished

1. **Fixed Github Repository**  
   - Fixed GitHub repository, pushed tutorial progress according to MDM guidelines (each commit includes a brief message and reflection).  
   - Configured Rider with Unity for scripting in C#.  
   - All tutorial work is safely pushed to GitHub in a dedicated tutorials folder within projects folder.

2. **Unity Learn:** [Essentials Pathway](https://learn.unity.com/pathway/unity-essentials%29)
   - **Editor Essentials**  
   - **3D Essentials**  
   - **Audio Essentials**  
   - **Programming Essentials**  

   Each mission took roughly two hours, and I worked step-by-step through videos and instructions. These covered scene navigation, prefab creation, physics materials, audio sources/listeners, basic scripting (C#), and more. Completing these has given me a solid grasp of the Unity Editor’s core concepts.


**Just a few of the [photos (link to Github photos folder)](https://github.com/xaynia/CART-315/tree/main/Process/Images/W4) I documented:**
   ![Ball-ramp-test-collison](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W4/Ball-ramp-test-collison.png)

Creating a horse mural:
![Mural-before](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W4/Mural-before.png)

![Mural-after](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W4/Mural-after.png)

Finding hidden numbers for Unity's launch year, and getting fireworks:
![Hidden-number-0](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W4/Hidden-number-0.png)

![Hidden-number](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W4/Hidden-number.png)

![Fireworks](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W4/Fireworks.png)


4. **Notes & References**  
   - **[Compiled detailed study notes](https://docs.google.com/document/d/19Ob0PXCKj5om9A9qJfeEV1U9GgErxdfeat1Ouwohhno/edit?usp=sharing)** (with screenshots) in a separate Google Doc. Because of the volume of images and formatting, I decided not to include them _directly_ in my GitHub process journal, but linked to this doc for reference.  
   - These notes include step-by-step instructions for Unity basics like game objects, materials, collisions, physics, and audio.
   - The notes include highlights from tutorials and much more photos as well.
   - Creating these notes will be cumulative – they help me consolidate information.

5. **Toggl Track Time Logged**  
   - Spent a total of **15 hours** on setup, tutorials, reading, and documentation for this week.

## Reflections

- **MDM Framework:** While most of my commits so far are tutorial-based, I’m practicing good habits by writing short reflections in each commit message. Even though these were guided by Unity’s lessons rather than my own design decisions, it’s good practice to capture what I learned and why it’s relevant.  
- **Comfort Level:** I feel more at home in the Unity interface now— I think getting over this inital hump was the biggest challenge. I feel particularly much more at ease navigating unity (e.g., using the scene view, using transform tools, and setting up basic scripts in Rider). The tutorials were very thorough and gave me plenty of hands-on practice, helping me feel confident navigating in Unity.  
- **Challenges & Insights:**  
	 - Navigating Rider remains something I need to get used to. I think more practice will definitely help!
  - Some tutorials can feel long, especially with the long hours I put into catching up, however the repetition helped solidify my understanding. Despite this, I will say, that learning the many nuances of the Editor (e.g., global vs. local coordinates, pivot vs. center modes) was very fun. 
 

## Next Steps

1. **Prototype Brainstorming**  
   - Begin brainstorming on a small unique game concept to apply these new skills.  
   - Narrow down a simple mechanic or theme to implement first—something I can build, test, and iterate on.
   - Start implementing weekly class content into a prototype.

2. **Rapid Prototyping & Iteration**  
   - Implement MDM framework more intentionally as I start my own project. For each “design move,” I’ll commit with a short reflection about my intent, changes, and next steps.  
   - Conduct quick playtests (even if it’s just me or a friend) to inform how I tweak gameplay mechanics.

3. **Add to the Process Journal**  
   - Continue writing weekly entries like this one.  
   - Potentially integrate a short “artist’s statement” or “manifesto” to clarify my game’s core idea once I have it.  

## Highlights
- **Repository:** Fully set up with a clear folder structure
- **Tools:** Rider + Unity successfully configured (no more environment issues).  
- **Unity Essentials Missions Completed:**  
  - Editor Essentials  
  - 3D Essentials  
  - Audio Essentials  
  - Programming Essentials  
- **Notes/Reference:** Created a robust reference document [Google Doc](https://docs.google.com/document/d/19Ob0PXCKj5om9A9qJfeEV1U9GgErxdfeat1Ouwohhno/edit?usp=sharing) with screenshots and detailed steps.  
- **Hours Logged:** 15 hours this week.  
- **Ready to Apply:** Confident with Unity’s interface and excited to brainstorm and build my first prototype. My goal is to start implementing weekly class content into a prototype.

----

# Week 5: Feb 13
**Exploration Prototype 3 – Design Journal**

![Single Sphere](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/Single-sphere.png)

I set out to recreate the magical feeling of Summit One Vanderbilt’s mirrored room, where spheres float around and visitors can interact with them. My idea was to spawn metallic spheres from above, have them land on a plane, and allow the player to walk among them. I added a FallingSphere prefab with physics, a Spawner script to make it rain spheres, and a simple WASD/mouse-look controller so I could freely explore the scene. Initially, the spheres vanished too quickly because of scale-shrinking code, so I removed that logic to let them remain visible and behave more like rain. When the plane was too small, I felt overwhelmed by spheres “drowning” the player, so I enlarged the plane for a better sense of space.

I also experimented with **singleton** usage to manage and track all the spawned spheres. While testing collisions, I ran into the frustrating problem of spheres either knocking the player over or passing through the ground when set to “Is Trigger.” After multiple attempts (including placing triggers on the spheres themselves), I eventually found that adding a **trigger collider** to the player worked best—allowing the spheres to collide normally with the ground but not shove the player around. Although I never fully got the spheres to disappear upon touching the player in this prototype, I tested two different collision setups (on the sphere vs. on the player) and learned a lot about Unity’s physics layers, triggers, and the basics of singletons.

Overall, I spent around **8 hours** coding and refining collisions, plus about **3 hours and 20 minutes** reading and note-taking, which I [uploaded to GitHub](https://github.com/xaynia/CART-315/blob/main/Process/Images/Notes/Week%205%20Book%20Notes.pdf). My next goals are to add more bounciness to the spheres, let the player interact with them more (like bouncing them around), and possibly implement a scoring system to further encourage engagement. Despite the challenges, the prototype now successfully spawns an endless “rain” of spheres inspired by Summit One Vanderbilt, and I have a much better grasp on how to combine singletons, colliders, and triggers for future projects.

![Falling Spheres](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/FallingSpheres.png)

![Falling Sphere Prefab](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/FallingSphere.png)

## Key Accomplishments & Notes

### Spawner & Prefab Setup
- Created a **Spawner** script that instantiates `FallingSphere` prefabs from above.  
- Added a player character with movement and camera look, improving immersion.

### Collision Challenges & Solutions
- Initially, spheres shrank too quickly or knocked the player over.
- Experimented with triggers on spheres (they passed through the ground).
- **Final fix**: a trigger collider on the player that would remove spheres on contact, while they still collided with the floor.

### Singleton Exploration
- Implemented a singleton to manage the sphere list and removal.
- Encountered collider issues unrelated to the singleton itself, but learned how to globally track and destroy spheres via a single manager.

### Time Logged
- ~8 hours on scripting, testing, and collision troubleshooting.
- ~3 hours of reading/documentation, posted to GitHub.

### Next Steps
- Increase sphere bounciness and add more interactivity (possibly a scoring mechanic).
- Continue refining player interactions—pushing or bouncing the spheres.


## References
- [Notes](https://github.com/xaynia/CART-315/blob/main/Process/Images/Notes/Week%205%20Book%20Notes.pdf)
- [Single Sphere](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/Single-sphere.png)  
- [Falling Spheres](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/FallingSpheres.png)  
- [Falling Sphere Prefab](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/FallingSphere.png)

