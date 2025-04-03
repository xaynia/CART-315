
# Process Journal

> **Note for self:**
>- **Journal:** diary, reflection on the status of the project, references, images and anything else that captures the normal elements of design and development as it happens.
>- thoughts and reflections throughout the process of prototyping games (e.g.,discussing the design goals for the current idea, what you made to test those ideas, what your take away from the prototype was, and what you intend to accomplish next.) 

---

# Week 1-2: Tiny Game


<details>
<summary> Bitsy Reflection (Click to Expand)</summary>
	
   After reflecting, and playing various inspiring Bitsy games, I have narrowed my focus to a Bitsy game. I like the dialogue, and simplistic art style. 

   The scene is at the shore. A raven sits there. An orca resides in the water. The characters journey is about finding guidance and comfort in nature at the shore, as they drift on their way to finding their purpose. 
   
   Rather than going to different rooms, the player walks along the beach in the same scene, collecting items along the beach. As the player collects various different items along the beach, the dialogue progresses, revealing the characters internal journey.

   Characters: 
   - Orca: Wise, mysterious. Knows the ancient, deep, mysterious wisdom of the ocean. Deep, like the ocean. The orca ocassionaly and majestically surfaces. Truly a sight to see when he surfaces, he spouts grand wisdom, before he returns to his pod.
   - Raven: the Trickster: May act as a guide. Sharp and confrontational in nature, in contrast with the orca. Vapid, like the air. The Raven croaks and caws, and flaps it's wings around.

   Items: 
   - Driftwood: May reveal objects, perhaps carvings, for the player to see. Maybe even symbolic of people.
   - Sea glass: Symbolizes transformation. Even from the roughest of seas, can bring a beautiful gem.
   - Shell: Triggers a childhood memory, about simpler times.
   - Fishing net: 

**Notes about Testing Bitsy:**
- I really liked the dialogue and simplicity with Bitsy. I spent a decent amount of time trying to figure out how to use it, seeing if I could add more than 3 colors into the color palette with the code. After I decided 3 colors wouldn't work (and a youtuber who confirmed I should infact stop) for my idea I decided to try Pico-8. I felt like I had a solid plan with my original idea. It was supposed to be a relatively fast game but have impactful dialogue about changes in life. From the games I tested in Bitsy, my favourite part about them is how impactful they can be, from this perspective. 
- Favourite Bitsy Games I tested:
  
https://zenzoa.itch.io/wandering-home

https://le-onionboi.itch.io/spoons

https://lolabug.itch.io/no-longer-human

</details>

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

**Notes about Ghost Tale & Pico-8:**
- I felt like I needed a plan intially, and even though I went into Pico-8 with no plan, the funnest part about creating Ghost Tale was actually that I had absolutely no plan, and went into a state of flow, rather. I decided to watch a youtube video of someone who learned Pico-8 in a day and made a game, and mentioned NerdyTeachers https://nerdyteachers.com/Explain/Platformer/ platformer series which helped me. After brainstorming a few ideas about a character, I chose a cute ghost. As for the movement, the ghost would just bob. From there, I had alot of fun designing platforms with an aesthetic which would match the ghost theme. From there I had alot of fun figuring out how Pico-8 works, laying the tiles I created, and testing movement and interaction, etc. I started laying tiles, and put a pit at the start of the game. I realized quickly that when the ghost fell down the pit, the camera did not follow. This required adjusting the update functions player.x variable. Once this was fixed I had so much fun designing the world! I realized I would need a way to end the game however, so I thought a treasure chest could work intially. After thinking about it some more, I thought finding the ghosts gravestone would make a good plot, so I went with that idea. From here I started testing flags, and realized I would need to add a message when you interact with them, which I added in the _Draw function. Once I got this working I thought adding false gravestones would be fun too, so I designed the false gravestone with a different flag and placed 3 of those in the world too. After this I would keep implementing changes, running the game and testing it, and repeat, until I was happy with the finished product. Overall I am happy with the game, and was really happy I ended up using Pico-8, especially since using Lua ended up having some overlap with Javascript, so it helped me with getting some terms and concepts to long term memory.

<details>
<summary> Examples</summary>

- e.g: Camera 
	
		cam_x=player.x-64+(player.w/2)
		if cam_x<map_start then
					cam_x=map_start
		end
		if cam_x>map_end-128 then
					cam_x=map_end-128
		end
		camera(cam_x,player.y-64)
		end
	
- e.g: Gravestone Win Condition Flag 

		function _draw()
			cls()
			map(0,0)
			spr(player.sp,player.x,player.y,1,1,player.flp) 
			
			print('your soul wanders restlessly \n you must find your grave',124,54)
			print('press x to jump',30,82)
	
</details>

## Ghost Tale

[Play my game on itch.io](https://xaynia.itch.io/ghost-tale)

**Spawn** 

<img src="https://github.com/xaynia/CART-315/blob/main/Process/Images/GhostTale-TinyGame/Spawn.gif?raw=true" alt="Spawn" width="60%" />

**Platforms** 

<img src="https://github.com/xaynia/CART-315/blob/main/Process/Images/GhostTale-TinyGame/Platforms.gif?raw=true" alt="Platforms" width="60%" />
<img src="https://github.com/xaynia/CART-315/blob/main/Process/Images/GhostTale-TinyGame/Platforms2.gif?raw=true" alt="Platforms 2" width="60%" />

**Respawn on Death** 

<img src="https://github.com/xaynia/CART-315/blob/main/Process/Images/GhostTale-TinyGame/Death.gif?raw=true" alt="Death Animation" width="60%" />

<details>
<summary> More gifs </summary>

**False Grave** 

<img src="https://github.com/xaynia/CART-315/blob/main/Process/Images/GhostTale-TinyGame/False-grave.gif?raw=true" alt="False Grave" width="60%" /> 

**Win** 

<img src="https://github.com/xaynia/CART-315/blob/main/Process/Images/GhostTale-TinyGame/Win.gif?raw=true" alt="Win" width="60%" />`

[More: Github Image Folder](https://github.com/xaynia/CART-315/tree/main/Process/Images/GhostTale-TinyGame)

</details>

# Week 3
>Note: I emailed you about this week.

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

### Creating a horse mural:
![Mural-before](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W4/Mural-before.png)

![Mural-after](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W4/Mural-after.png)

### Finding hidden numbers for Unity's launch year, and getting fireworks:
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


# Week 5: Feb 13
**Exploration Prototype 3 – Design Journal**

![Single Sphere](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/Single-sphere.png)

I set out to recreate the magical feeling of Summit One Vanderbilt’s mirrored room, where spheres float around and visitors can interact with them. My idea was to spawn metallic spheres from above, have them land on a plane, and allow the player to walk among them. I added a FallingSphere prefab with physics, a Spawner script to make it rain spheres, and a simple WASD/mouse-look controller so I could freely explore the scene. Initially, the spheres vanished too quickly because of scale-shrinking code, so I removed that logic to let them remain visible and behave more like rain. When the plane was too small, I felt overwhelmed by spheres “drowning” the player, so I enlarged the plane for a better sense of space.

I also experimented with **singleton** usage to manage and track all the spawned spheres. While testing collisions, I ran into the frustrating problem of spheres either knocking the player over or passing through the ground when set to “Is Trigger.” After multiple attempts (including placing triggers on the spheres themselves), I eventually found that adding a **trigger collider** to the player worked best—allowing the spheres to collide normally with the ground but not shove the player around. Although I never fully got the spheres to disappear upon touching the player in this prototype, I tested two different collision setups (on the sphere vs. on the player) and learned a lot about Unity’s physics layers, triggers, and the basics of singletons.

Overall, I spent around **8 hours** coding and refining collisions, plus about **3 hours and 20 minutes** reading and note-taking (tracked via Toggl Track), which I [uploaded to GitHub](https://github.com/xaynia/CART-315/blob/main/Process/Images/Notes/Week%205%20Book%20Notes.pdf). My next goals are to add more bounciness to the spheres, let the player interact with them more (like bouncing them around), and possibly implement a scoring system to further encourage engagement. Despite the challenges, the prototype now successfully spawns an endless “rain” of spheres inspired by Summit One Vanderbilt, and I have a much better grasp on how to combine singletons, colliders, and triggers for future projects.

![Falling Spheres](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/FallingSpheres.png)

![Falling Sphere Prefab](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/FallingSphere.png)

## Reflection
This felt like my first time using Unity without "training wheels" (i.e.: practicing Unity Learn tutorials, reading about Unity, or taking notes), which made starting my first Unity project from scratch both overwhelming and relieving (to finally be practicing what I have learned) at the same time.  

I met my goal of starting a prototype this week! I am very happy about that. Tracking my time in Toggltrack has been very helpful for me to figure out how to have a better week the next week, as well as manage my time. I feel like I am getting better at navigating Github, and Rider, and Unity too – even if it feels overwhelming at times (mainly because of how much there is to know in Unity before you even use it).

Currently I'm trying to find the right balance between learning and practicing in Unity. I plan to keep sprinkling in more guided Unity Learn tutorials (scripting and smaller game tutorials, currently), because they help me feel more comfortable using Unity. And I also plan to start start working on my weekly prototypes earlier in the week too. I think learning and practicing in Unity is exactly what I need to be doing before I can come up with a concrete idea for my final project – but I do plan on starting to checkout more Youtube videos to get ideas flowing too. 


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

### Prototype Potential Next Steps
- Increase sphere bounciness and add more interactivity (possibly a scoring mechanic).
- Continue refining player interactions—pushing or bouncing the spheres.

## References
- [Notes](https://github.com/xaynia/CART-315/blob/main/Process/Images/Notes/Week%205%20Book%20Notes.pdf)
- [Single Sphere](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/Single-sphere.png)  
- [Falling Spheres](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/FallingSpheres.png)  
- [Falling Sphere Prefab](https://github.com/xaynia/CART-315/blob/main/Process/Images/W5_ExplorationPrototype3/FallingSphere.png)
- [Github Images and Notes Log](https://github.com/xaynia/CART-315/tree/main/Process/Images)  

# Week 6:  Feb 20 | *Exploration Prototype 4 (Continuation)*

> ## What Changed This Week
>- Fixed the **trigger collision issue** (the spheres not disappearing on player contact), by adding the correct tag `FallingSphere` (to sphere prefab being spawned) that `PlayerTriggerZone`  script was looking for.
>- Added a `score` variable to the Spawner (singleton): increases score when player contacts spheres
>- Created a TextMeshPro UI display for the score


### Debugged Singleton Logic: Spheres Now Disappear on Player Contact
Picking up from last time, I investigated why the spawned spheres wouldn’t disappear upon player contact. I discovered the issue: the sphere prefabs which were being spawned were missing a necessary tag that the `PlayerTriggerZone` script was checking for (missing tag: `FallingSphere`).

```csharp
public class PlayerTriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FallingSphere"))
        {
            if (Spawner.instance != null)
            {
                Spawner.instance.RemoveSphere(other.gameObject);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
    }
}
```

Once I added the correct tag, `PlayerTriggerZone` script checks for the sphere’s tag, then it calls `Spawner.instance.RemoveSphere` (from `Spawner` Singleton script) to remove and destroy the sphere whenever the player collides with it.
![Singleton Logic: Player Contact Makes Spawned Sphere Disappear](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W6_ExplorationPrototype4/SingletonLogicDebug-SpheresDissapearonPlayerContact.gif)

### Added Score in Singleton Spawner and Score UI (TextMeshPro)
Using the same newly working logic, I introduced a `score` variable to the `Spawner` singleton script. Whenever `RemoveSphere` is called (i.e., when a sphere is collected by the player), the score increases by one.

To display the score, I created a UI Canvas with a child TextMeshPro UI object. I then added a `ScoreDisplay` script
```csharp 
using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using TMPro;  
  
// Score Display Script
public class ScoreDisplay : MonoBehaviour {  
  public TextMeshProUGUI scoreText;  
  
  void Update() {  
  //  Show the current score (Spheres player collides with [from the Spawner])  
  scoreText.text = "Score: " + Spawner.instance.score;  
 }}
```
to the child, and in the inspector dragged the TextMeshPro component onto the script's scoreText field. This script references `Spawner.instance.score` to show the current score on the screen.

![Score UI](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W6_ExplorationPrototype4/ScoreUI.gif)
I adjusted child Y position settings, max/min size, alignment, and position to be small in the top left corner. I set parent render mode to overlay too.
![Resized Score UI](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W6_ExplorationPrototype4/SmallerScoreUI.gif)

## Challenges (Troubleshooting)

### Adding TextMeshPro UI

I spent about an hour fixing the hot-pink text issue in TextMeshPro. This happened because I added the UI code to the Score GameObject in play mode, and missed a notification from Unity to download the TMP Essential Resources. so once I realized I needed this, first, I manually imported them TMP resources in Unity.
![Debugging UI](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W6_ExplorationPrototype4/Debugging.png)
 Then, I changed the font asset and material preset for `TMP_SubMeshUI` components to **LiberationSans SDF** and **Unity Atlas Material**, which solved the problem
![Score UI](https://raw.githubusercontent.com/xaynia/CART-315/main/Process/Images/W6_ExplorationPrototype4/ScoreUI.gif)


 ### Rider: Push Error
After I finally got everything working and tested the UI, I pushed everything in Rider (the changes and a few hundred of the new TextMeshPro  files), Rider sent a notification to authorize Github again in the browser which I accidentally closed, and then I got the error.
 
	 error: RPC failed; HTTP 400 curl 22 The requested URL returned error: 400 send-pack: unexpected disconnect while reading sideband packet.

 I spent another hour *attempting* to troubleshoot the error in Rider, and Github Desktop (I tried reauthorizing Github, undoing the changes, trying to push them (because nothing was actually pushed), etc).

After coming back to it the next day and [looking up the issue online](https://stackoverflow.com/questions/77856025/git-error-rpc-failed-http-400-curl-22-the-requested-url-returned-error-400-se), I fixed by increasing the buffer size with:

	git config http.postBuffer 524288000

Then I re-attempted the push. I also added a `.gitignore` to exclude some TextMeshPro example resources.

### Perfectionism and/or Time Blindness?
I logged **22 hours this week** in TogglTrack (Monday–Wednesday). Yet despite putting in a lot of time, I feel like I haven’t accomplished as much as I’d hoped. I suspect perfectionism and/or maybe time blindness are making tasks take longer. I’m trying to balance my desire to produce high-quality work with the reality that programming can be time-consuming—and more so when I’m still in the early stages of learning, while learning two programming languages at once.

### Balancing Unity Progress and Documentation
I also find I’m spending a considerable chunk of my time creating journal entries to document what I’m doing. This may be due to perfectionism, but I'm feeling spread thin.  I also need to focus on making real progress in Unity, researching game ideas, and practicing new scripting concepts. I’m still trying to find a happy medium between documenting everything and keeping a good development pace. 

## Reflection
Debugging the UI took longer than expected, mainly because I was juggling multiple scripts and couldn’t pinpoint the problem. It turned out to be a small oversight—missing the proper tag. Even so, it took me about an hour to trace that down.

Troubleshooting the Rider push error also took a long time. In hindsight I spent alot of time blindly trying to fix the problem and I should have looked it up sooner. I'm still not entirely sure if the TextMeshPro files caused the error, or if closing Github authorization popup tab during the push caused the error, but I assume it's the former.

Despite the challenge, I feel more organized this week. I started earlier, kept track of my time, and wrote my journal as I went along. This consistent workflow makes me feel like I’m finally getting into a programmer’s mindset.

I also discovered _Gifski_, a Mac app that converts videos into GIFs, making my documentation more visual. Additionally, I’ve been using _StackEdit_ for Markdown writing, which helps me preview changes in real time (though it lacks custom commit messages) – It's really helping me learn markdown well.

### Goals:
My main goal since the last prototype was to finish what I started (to fix the trigger collision logic), which I accomplished. Building on this, I also added a score system with UI to track how many spheres the player collects.

### What I learned:
1.  How to add TextMeshPro UI to track score.
2.  To always check Rider for warning notifications (that’s how I discovered a missing `<tag>`).
3.  Be careful when pushing big file libraries (they may cause Github can cause errors—.gitignore is essential.)

### Accomplishments: Success?:
On one hand, I’m happy to have achieved my goal of fixing the trigger collision and adding a score system—those were my main technical objectives. On the other hand, I still feel like I should be doing more in Unity itself. So, while the outcome is good, I do feel overwhelmed and wish I had more tangible progress in Unity. Given that programming is new to me (and I'm learning two languages concurrently). However, I keep reminding myself learning learning to code takes time.

### Future Exploration:
Now that I have the score system and sphere spawner working, I think it would be fun to turn the prototype into a game of soccer or baseball to keep exploring. Maybe with other NPC characters too.

Another idea would be build a skyscraper and mirrored/glass room like the original idea.

I want to begin experimenting with multiple scenes, and start  building an environment so I can start adding special objects (like I mentioned in bonus entry) too. And then also and start exploring player customization or abilities.

Eventually, I’d love to implement a magical mechanic that maybe ties into the abilities. Even though it feels far off, I’m excited by the idea of adding magic powers, spells, or elemental effects to the gameplay (I'm inspired by Eldin Ring too).

## Resources
- [Link to Project Folder (Continuation of Last Week’s Prototype 3)](https://github.com/xaynia/CART-315/tree/main/Projects/ExplorationPrototype3) 
- [Week 6 Image Log](https://github.com/xaynia/CART-315/tree/main/Process/Images/W6_ExplorationPrototype4)

# Week 6: Extra Credit Game Analysis: 

> **Game Analysis:**
> Find a game that you know well or are intrigued by. 
> What decisions have the designers made that cause the game to be interesting? 
> Where have they failed? Think mechanically rather than thematically.
>  What ideas/methods/techniques do you think you could borrow for future projects?

 ### *Zelda Tears of The Kingdom* (TOTK)
 
##  Interesting Design Decisions

#### Link's Abilities:
Link has several abilities, each earned during a shrine. These abilities allow you to manipulate objects, affecting the way you can interact with the game.

- **Ultrahand:** move/rotate/bind objects
	- bind multiple objects (up to 21) together to create new objects 
		- bind zonai devices with objects to create vehicles, flying devices
- **Fuse:** combine objects to create new items
	- combine weapons/shields with materials in the world
- **Recall:** allows you to reverse an objects movement in time.
- **Ascend:** allows link to travel through solid ceilings above him

These abilities open up a new realm of creative possibilities. They’re interesting because they let players choose *how* to tackle puzzles and combat, encouraging inventive solutions. 

For example:
- Reach areas you normally couldn’t by combining Recall, Ascend, and Ultrahand.
- Use Ultrahand in combat (e.g: dropping boulders on enemies). You can move multiple items at once too.
- Fuse allows you create a range of special weapons/shields/arrows
	- e.g: 
		- fuse an icicle with a weapon/shield to create a freezing weapon (i.e., freeze enemies)
		- freeze monster parts (shows fuse attack power) with weapon to create strong weapon 
		- fuse inventory item to arrow when shooting arrow
			- e.g:
				- bomb flower + arrow = bomb arrow
				- fire fruit + arrow = flaming arrow

### Physics
What makes these abilities so special is how they interact and change the physics of objects. This interplay is central to the entire game (exploring, combat puzzles, etc). For instance, the game’s physics engine treats every fused item or Zonai device as a physical object with its own weight, collision, and momentum—so when you bind them together, the physics engine tries to simulate them realistically. This enables players to experiment with a sense that anything could work if they find the right combination or angle, which not only fuels creativity but also solutions to challenges.

## Design Fails
### Overly Exploitable Ability Physics: 
The game’s physics engine and abilities create endless possibilities. Vehicles and flying devices made from Zonai devices are intended to be limited by Zonai battery. However, because you can combine almost anything, it’s common to see vehicles **modified** in ways the developers never intended.

**Examples:**

**e.g: No Battery Infinite Flight Aircraft**  
I found (one of many examples on [Youtube](https://www.youtube.com/watch?v=7uzDn_20oiE&t=10s)) this build which does this to create this exploit:
>- **Fuse** a Flux Construct I block part to your shield/weapon (you don't even need to defeat it, you can just attack it, and fuse his part)
>- **Fuse** a propeller (from *Turbine Power* Shrine) to your shield/weapon. 
>- Then go to Peilison in Tarrey Town, an NPC you can pay to **unfuse** them. 
>- Then you can use **ultrahand** to bind the parts together to create the build 
>- Also needed: speark-like weapon (e.g. pitchfork), and a Zonai steering stick (uses no Zonai power)

This exploit bypasses the limit (Zonai power, and intended flying devices) created by the game entirely. And by fusing and unfusing items, players can gain access to building blocks they weren't intended to use to build. Since it completely sidesteps the energy-cell system (collecting batteries, managing flight time), core progression elements become moot.

**e.g:  Infinite Battery Exploit with Cooking Pots**
>- When flying with a hot air balloon, you normally lose altitude if the battery depletes. By opening your inventory and using a single-use cooking pot (Zonai item), you effectively reset or recharge your battery, preventing the balloon from dropping.

The original design goal—requiring players to plan battery usage—is undermined when you can simply reset your Zonai energy on demand.

**e.g: Preventing Gliders from Despawning**
>-   If you attach extra fans backward on a glider and mount a steering stick, the glider won’t nosedive or despawn once battery runs out.
>-   It essentially remains functional, letting you fly indefinitely without burning additional resources.

Glider despawning was intended to limit flight duration. This exploit overrides the limitation, which again, makes exploration become trivial.

**e.g: Infinate Heigh Glitch**
>- If you place a stabilizer onto a U-shaped block (from the depths), stand in it, trigger a memory cutscene, and exit. 
>- This can catapult Link high into the sky, effectively creating infinite height gain

This glitch bypasses standard travel mechanics (e.g.: rockets, hot air balloons) which again have limitations. This matters mechanically because it allows players to bypass environmental challenges and achievements (like climbing mountains, or reaching floating islands, etc).

### Unbalanced Arrow Supply/Demand
Arrows are in high demand and can be frustratingly scarce or expensive, prompting repetitive rupee farming methods, or infinate arrow glitches/exploits. 

Arrows are in high demand but can be scarce or expensive, encouraging repetitive rupee farming (e.g., gem farming from Stone Talus spawns) or reliance on infinite-arrow glitches/exploits. The pricing and availability of arrows could perhaps be a design oversight. While the developers likely intended some scarcity, it can feel overly punishing or tedious, driving players to repetitive grinds just to get basic resources.

### Save/Load Abuse: 
Players can save right before a difficult fight and reload repeatedly if they fail, negating many of the intended risks. This design choice removes tension from high stake battles because it removes risk (penalty and losses), and inadvertently reduces difficulty. Some players appreciate it; others see it as diminishing challenge.

## Borrowable Ideas/Methods/Techniques for Future Projects

**The creative abilities and physics truly form a double-edged sword.** On one hand, Link’s expansive toolkit is a huge part of what makes the game so appealing, because there are practically endless possibilities to tackle any situation.

On the other hand, with so much creative freedom, players naturally discover ways to bypass design intent—like building flying vehicles that ignore intended flight-time limits. I can see why TOTK puts restrictions on flying devices, given that real-life aircraft have resource constraints. Meanwhile, other games (like GTA) don’t bother with flight limits (planes needing no fuel), providing a whole different play experience without those concerns.

Still, I’ve got to give props to the players and TOTK for crafting such a robust physics simulation, where everyone can invent and test imaginative creations in ways that even the developers might not have foreseen.

### Player Abilities:
What I would takeaway from TOTK, is the idea of the abilities being something people could only dream of having. I would opt for some different abilities, thinking about guardrails to prevent exploits (e.g: balance them with resource costs or situational limitations)
- Elemental manipulation (player can manipulate fire, air, water, earth, light)
- Teleportation (similar to map teleportation in TOTK)
- Necromancy
- Ability for *character* to fly (defy physics)

### Game Physics Ideas:
- Element interaction
	- e.g: 
		- Ice and fire (and magma when you combine them)
		- Fire melts ice
		- Water can heat/freeze 
		- Food can heat/freeze

### Cooking Mechanic:
I love the cooking mechanic in TOTK. I love how it enables you to explore, gather items, and experiment. The cutscene is wonderful too, and the experience feels very cozy. I do wish, however, there was *more* recipes creations. 

**Some of my favourite aspects of TOTK cooking:**

There are so many **different ways to cook**:
- **Meal:** food ingredients cooked in a pot 
- **Elixir:** critter and monster part cooked in a pot
- **Roast:** food cooked by fire (or extreme heat)
- **Frozen:** food laid on freezing ground
- **Boiled:** egg put in hot spring
- **Fairy Tonic:** fairy + recipe
- **Dubious Food:** minimally restores HP (recipe fail)

And different cooking **effects**:
- **Meal:** restores hearts (HP), special effects
- **Elixir:** restores 2x hearts (HP), special effects
- **Roast:** restores less hearts (HP), but stacks in inventory
- **Frozen:** provides heat resistance
	- can fuse to shield to shield surf
- **Boiled:** egg put in hot spring
- **Fairy Tonic:** restores 2x hearts (HP), prevents dubious recipe

And different **ingredient effects** to cook with:
- **Hearty**
- **Spicy**
- **Chill**
- **Mighty**: increases attack
- Normal

### Object Special Effects:
An overarching theme of cooking and fuse, is **object properties which have effects**. I like the idea of adding special properties to objects in the game (herbs, fruits, gems, etc) that be used (e.g. cooking, to make weapons more powerful) to encourage players to combine items in strategic ways.

## Closing Thoughts
In the end, what I love most about _Tears of the Kingdom_ is its ability to **spark creativity** through abilities and physics—letting you **experiment** and solve challenges in countless ways. This design is definitely a double-edged sword: the same openness that makes the game so fascinating can also lead to players bypassing large chunks of content. Still, I’m blown away by just how expansive and polished the physics system is, even if replicating it on that scale would be tough for most projects. Instead, I’d aim to borrow some of my favorite ideas, like **player abilities, dynamic cooking, objects with special properties, and elemental interactions**—and adapt the abilities with a bit more caution.

# Week 7: Iterative Prototype 1
> Journal about the first stage of your prototyping process. What was your idea? What specific questions where you trying to answer (goals)? Was it a look/feel, role, implementation prototype?What fidelity levels are you dealing with? What did you learn and what are the next steps?

## Idea
Our primary concept is a **defend-the-castle** style game where the player must protect a magical crystal (or orb, etc) from waves of incoming monsters. The core mechanics revolve around spellcasting: the player uses projectiles or spells to repel enemies that spawn at increasing rates. This forms the foundation of our game, and we plan to layer additional features—like varying environments, elemental power-ups, and possibly an inventory system—after we establish the basic combat loop.

### Design Values
1.  **Immersion in a Magical World**: We want players to feel truly embedded in a fantasy realm, experiencing the thrill of spellcasting and defending a sacred artifact.
2.  **Progression & Challenge**: As waves increase in difficulty, the sense of progression is key, offering a rewarding loop for players who successfully upgrade or learn new spells.
3.  **Scalability**: Start with a simple but solid core (castle defense), then scale up with new elements (inventory, environment interactions, elemental powers) if time permits.
4.  **Player Agency**: The player should have multiple spellcasting choices and strategic options (e.g., positioning, resource management) to keep the gameplay engaging and varied.

### Three favourite ideas
1.   **Mini Open-World with Combat & Magic**  
    Inspired by _Zelda: TOTK_ and _Elden Ring_, a small but explorable environment where players can gather resources for spells, interact with NPCs, and fight roaming monsters.
    
2.   **Horde Defense with Elemental Interactions**  
    Waves of enemies approach while the player uses elemental spells (fire, ice, lightning, etc.) that can combine for special effects (e.g., oil + fire = increased burn damage).
    
3.   **Puzzle-Integrated Spellcasting**  
    A puzzle layer in which spell combinations unlock doors or reveal hidden paths—possibly using illusions or invisibility to navigate stealth segments.
    
We ultimately chose to focus on the **horde defense** aspect first, as it offers a clear core challenge and is easier to implement in our initial prototype.

## Goals

First, we aim to get the barebones foundation of our defend-the-castle game working. These steps will let us test the core loop: the player casts spells at waves of monsters trying to destroy the orb.
### Weekly Goals
- [ ]    **Create a Monster GameObject** (basic model/placeholder)
- [ ] **Create a Crystal/Orb GameObject** (the target to defend)
- [ ] **Implement Basic Projectile/Spellcasting**
	- Simple projectile script
	- Collision detection with monsters (could potentially use my previous collision detection script)
- [ ] **Set Up a Simple Wave Spawner** (enemy waves) (could use my spawner script)
	- Very basic AI to move towards the orb
- [ ] **Implement Health & Damage**
	- Monster health/dying on 0 HP
	- Orb health (game over if destroyed)
	- Player health
- [ ]    **Basic UI feedback** (player health, crystal health, score).

Our immediate goal is to validate the core gameplay loop—does defending an object with spell-based combat feel satisfying, challenging, and fun? By testing early, we can confirm whether our combat mechanics are engaging enough to expand upon.

##  Questions We’re Trying to Answer
1.  Can we implement smooth spellcasting mechanics with a basic projectile system in Unity?
2.  Is the pacing of enemy waves balanced for a “defend-the-orb” style challenge to maintain player engagement?
3.  How feasible is it to add additional features (inventory, elemental combos, etc.) later without breaking the core loop? 

### Was it a look/feel, role, or implementation prototype?
This prototype primarily focuses on **implementation**. We are building scripts for monster AI, projectile casting, and object defense to see if our gameplay mechanics work under real conditions. While we do care about some basic aesthetic consistency (a fantasy look/feel), the priority is functional testing over polished visuals.

### Fidelity Levels
**Low- to Mid-Fidelity**: We’re using placeholder 3D assets or basic shapes, as well as simple UI elements for scoring and health. This allows us to iterate on gameplay without getting bogged down by final art or detailed environment design.

## Next Steps
- [ ] **Integrate Scoring** using existing scoring system
- [ ] **Implement Basic Spellcasting**:
    -   Use a projectile system in Unity.
    -   Ensure it feels responsive (speed, damage, cooldown).
- [ ] **Create Enemy Waves**:
    -   Set up a spawner that gradually increases wave difficulty.
    -   Basic AI: move towards the crystal/orb and attempt to damage it.
    - Adjust speed, spawn rate, difficulty)
- [ ] **Protect the Crystal**:
    -   Implement a health system for the orb (and possibly the player).
    -   Show basic feedback when the crystal is hit.
- [ ] **Set Up a Simple Scoring System** _(already made in Unity but needs integration)_
    -   Points awarded per monster killed.
    -   Possibly track wave count or “time survived.”
- [ ] **Refine Enemy AI and Balancing**
    -   Tweak spawn rates, enemy health, and damage for a more engaging pace.
    -   Consider different enemy types if time allows (faster but weaker vs. slower but stronger).
- [ ] **Enhance Spellcasting System**
		-   Implement cooldowns and a basic mana resource.
	    -   Experiment with elemental spells (fire, ice, lightning) to test synergy.
- [ ] **Improve UI/UX**
    -   Display player health, orb health, wave counters, and scoring in a clean layout to track progression
    -   Add simple menus or pause screens as needed.
- [ ] **Expand to Elemental Power-Ups**  
    -   Introduce special items or pickups that alter spell damage or add new spell effects.
 
**Ideas for Broader Features (If time permits):**

-   **Shop** with points and upgrades, and interface
	- [inspiration game](https://www.crazygames.com/game/defend-your-castle)
-   **Explore Elemental Power-Ups** prototype collecting items that grant different spell attributes or buffs.
- **Elemental Power-Ups**   Introduce special GameObjects (e.g.: fire/ice mushrooms/peppers/crystals) that alter spell damage or add new spell effects, and potentially add interactions between them
		- could be stored in an inventory system, or the player could automatically wield special new mana (and then maybe use left and right arrow keys to switch between spell type)
- **Mini Open World Features**  shop, puzzle area(s), treasure chests, buildings, NPC's
	-   **Puzzle Integration** puzzle areas


# Week 8: Iterative Prototype 2: Adding Enemy AI & Health Mechanics

![AttackHP](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/Attack2.gif)

> Journal about the first stage of your prototyping process. What was your idea? What specific questions were you trying to answer (goals)? Was it a look/feel, role, or implementation prototype? What fidelity levels are you dealing with? What did you learn and what are the next steps?

### Last Weeks Accomplished Goals
- [x]    **Create a Monster GameObject** (basic model/placeholder)
- [x] **Create a Crystal/Orb GameObject** (the target to defend)
- [ ] **Implement Basic Projectile/Spellcasting**
	- Simple projectile script
	- Collision detection with monsters (could potentially use my previous collision detection script)
- [ ] **Set Up a Simple Wave Spawner** (enemy waves) (could use my spawner script)
	- Very basic AI to move towards the orb
- [x] **Implement Health & Damage**
	- Monster health/dying on 0 HP
	- Orb health (game over if destroyed)
	- Player health
- [x]    **Basic UI feedback** (player health, crystal health, score).

## Idea

Building on the concept of a **defend-the-object, hoarde** style game with magic (spellcasting), this week I focused on implementing the fundamental systems behind **enemy movement**, **enemy attacks**, and an **HP/Health bar** system. The goal remains to create a horde-defense scenario where enemies spawn, move toward a critical target (like a magical crystal or orb), and attempt to damage it, while the player defends.

I introduced Enemy AI scripts that let enemies move toward the Target, attack if in range, and manage their own health. I also added a universal Health script that can be attached to the Player, the Target, and any Enemy. Also, I implemented a Health Bar UI element that appears when attacked, giving immediate visual feedback on damage.

1.  **Enemy Movement & Attack**
    -   The enemy moves toward a specified `Target` transform and attacks when within `attackRange`.
    -   A cooldown prevents it from spamming the attack every frame, preserving balance and clarity.
2.  **Health Script**
    -   Any character/object can have `maxHealth`, take damage via `TakeDamage(float)`, and handle death with a simple `Die()` method.
    -   An event-based approach (`OnHealthChanged`) allows the **Health Bar** to update only when damage actually occurs.
3.  **Health Bar UI**
    -   A World Space canvas and a fill `Image` let me display health visually above each entity.
    -   It’s now trivial to see if the Target or an Enemy is near death, or if the Player is about to be overrun.

### Design Values

-   **Clarity of Core Mechanics**: Ensure that the basic loop of “enemy spawns → enemy chases target → target/enemy takes damage” is solid.
-   **Simplicity and Extensibility**: Keep the scripts modular (Enemy script, Health script, HealthBar script) so they can be easily extended for multiple enemy types, player attacks, etc.
-   **Minimal**: working without game assets to get the core mechanics down before adding aesthetic features
- **Immediate Visual Feedback**: Add a minimal but clear UI component (the health bar) to show damage and health changes, to quickly grasp what’s happening when testing

## Goals
My goal was to start implementing a core foundation (enemy AI movement and attack, health logic [i.e. damage & death],) to setup a basic defend-the-object prototype. This lays the groundwork for future expansions— enemy hordes, adding player spellcasting, and so on.

## Questions to Answer

-  **Does a single “Health” component work well for multiple objects?**
    -   Yes—things remain consistent, and debugging is simpler.
-  **Is the movement & attack AI robust enough for horde-style gameplay?**
    -   For a basic prototype, yes. I can build on it with pathfinding or advanced behaviors later.


### Was it a look/feel, role, or implementation prototype?

**Implementation Prototype**: The focus was on functional scripts (Enemy logic, HP system, UI feedback). The look remains placeholder-like, with minimal art (without assets) to validate the underlying mechanics, to build a foundation to expand upon later. Even so, the look/feel aspect of having a floating health bar contributes to clarity in the user experience.

### Fidelity Levels

**Low to Mid-Fidelity**: Using simple capsule placeholders for enemies, a minimal cube target object, and a simple green/red health bar. There’s no finalized art or animation—just enough mimimal visuals to verify functionality.

## Accomplishments
### Created an Enemy Script (Movement & Attack) (`Enemy.cs`):
   - **Movement**: Moves the enemy toward a designated `Target` transform using a `moveSpeed`.
   - ![Enemy-player.gif](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/Enemy-player.gif)
   - **Attack Logic**:
        -   Defines an `attackRange` to decide how close the enemy must be to attack.
        -   Uses `attackDamage` to define how much damage is applied.
        -   Includes an `attackCooldown` to avoid attacking every single frame.
        -   ![Enemy Settings](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/Enemy-script2.png)
- **Health System**: The enemy (as well as the player and target) can have the same `Health` script attached, allowing them to take damage and potentially be destroyed at 0 HP.

### Implemented a Universal Health Script (`Health.cs`):
   - Stores `maxHealth` and `currentHealth`.
   -  ![Health Settings](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/Health-script.png)
   - Allows you to customize unique max health for any object (i.e., player, object, target) you put it on
    -  Provides a `TakeDamage(float amount)` method for reducing HP and checking for death.
    -  Notifies health bar via event (`OnHealthChanged`) when health changes
    - handle death with a simple `Die()` method.

### Added a Universal Health Bar UI (`HealthBar.cs)`:

   -   Created health bar UI using a World Space Canvas with a child Image serving as the fill for the health bar to display health visually above any objects head
   -   Ensures the bar only appears and depletes when the character is damaged.
   -   Positioned the health bar above each entity’s head for clarity
![Healthbar.gif](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/Healthbar.gif)


## What I Learned

1.  **Reusability is Key**: Having one Health and HealthBar script for all objects saves a lot of work and ensures consistent damage/HP behavior. 
2.  **Feedback is Crucial**: Seeing an on-screen health bar clarifies the state of battle—makes it easier to test AI logic or balance.
3.  **Minimalism > Details to Start**: The simple approach to AI (direct movement to Target, no pathfinding) meets the immediate needs but might need upgrading 

## Next Steps (Goals)

- [ ]   **Magic/Projectile Player Attack Mechanism**: Add projectile magic for the player to damage enemies 
	- calling `TakeDamage` on hit)
- [ ]   **Integrate the Spawner** so multiple enemies (hordes) appear over time. 	
- [ ]   **Confiagure Horde Code**: Test how the current movement and attack logic scales with many enemies.
	- Tweak spawn rates, speeds, and wave size to test the core loop.
- [ ]   **Allow Enemies to Attack the Player** (not just the target), so the player must actively defend themselves.
- [ ]   **Polish & Balancing**: Tweak HP, damage values, and wave pacing to ensure the game is both challenging and fair.

### Question to answer: Once hoardes are set up with the spawner, will players remain engaged?

>**Longer-Term Ideas** (If time allows):
>- **Hoarde levels**: After integrating the spawner, add variation (levels, increasing difficulty) in enemy hoardes
>-   **Spell Variation** for the player: implement multiple spell types (fire, ice, chain lightning, etc.).
>-   **UI Enhancements**: More sophisticated health bars, possibly with floating damage text or icons.
>- **Shop**
>-  **Add “Death” Feedback**: Animations, sound effects, or particle effects for both enemies and the Target when they die.

## Links:
- [Link to Project](https://github.com/xaynia/CART-315/tree/main/Projects/Final)
- [Link to Project Media](https://github.com/xaynia/CART-315/tree/main/Process/Images/FinalProject)

# Week 9: Iterative Prototype 3: Added Game Over UI, Assets, Level Design

![TestingAssets](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/TestingAssets2.png)

### Accomplished Goals

 - [x] Added Game Over UI (as a new scene)
 - [x] Downloaded Assets
 - [x] Started Level Design
 - [x] Added health bar to enemies

## Idea
With the core loop in mind, we are adding the most important features. The idea is during the wave you attack the horde while picking up objects in the scene and collecting them in your inventory. Then after the wave you can use the items you collected at the crafting area for a spell/weapon upgrade(s). Then repeat.

### Core Loop

 - **Level 1:**
	 - Horde
		 - Waves coming to player (waves progressively getting 
	 - 	 Gather items in the level
 - **Craft**
	 - Where you can use the items you collected to upgrade your weapon (e.g.: use red mushrooms you collected to unlock flamethrower)
 - **Level 2...** (repeat)

This is a look/feel and implementation prototype. It is a look/feel prototype as I am testing assets. I am also implementing UI and designing a game level with the assets.

#### Fidelity Levels:
It's a low-medium fidelity levels, adding assets from the Unity asset store and adding UI with TextMeshPro.

## Accomplishments

### Added Game Over UI 

![TestingAssets](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/TestingAssets2.png)

First I made as a scene, using TextMeshPro again. The game over UI is called when the core aka target dies, causing the scene manager to load the game over scene, which pops up "Game Over" text, and a "Try Again" button, which brings the user back to the level when pressed.

In the game over scene: I created a UI canvas GameObject (with script), with a text child "Game Over", and a button child which on click () uses the parent script to run GameOverMenu OnTryAgainButtonPressed (). The button child has a text child for the "Try Again" text.

The script uses `usingUnityEngine.SceneManagement;` to call the new scene with `SceneManager.LoadScene()`

And using the health script, when the core (aka target) dies it calls a cursor (to click the try again button), followed by SceneManager to load the game over scene
`SceneManager.LoadScene("Scenes/Game Scene/GameOverScene");`

This is the basic logic for the UI, and the idea is to add more to it later (i.e.: high score, save, etc)

![GameOver](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/GameOver2.gif)

### Downloaded Assets
I downloaded a bunch of assets to start designing and customizing the level.

**Questions**:

 - What is the difference between Built-in vs. URP (Universal Render Pipeline) vs. HDRP assets. 
 - When assets load in hot pink: are they incompatible? can they be converted?
 -  What is the asset manager useful for? how do you set it up?


### Started Game Level/Scene Design

#### Adding assets:
I'm using the assets to design the level for the game. I've made a scene to experiment with them. 

## What I Learned

To add a game over scene, I had to add a camera and event system for it to work properly. The camera had to be added to avoid a "no camera" popup over the UI when testing it. And the EventSystem is added to detect mouseclicks. Also I added all the scenes.

To use the scene manager to swap scenes, the scenes must be added to to the build profile (so the scene manager can load it). I used this for my game over UI.

## Next Steps (Goals)

 - [ ] Find red asset for collectable GameObject to craft flamethrower (red plants/mushrooms/gems etc)
 - [ ] Finish level/scene
	 - [ ] Add red collectable assets
 - [ ] Update Core/target health to enemy health bar
 - [ ] Add Wave Spawner to Spawner script: 
 
**UI:**
 
 - [ ] Add save system
 - [ ] Add high score
 - [ ] Configure score UI working (so it updates with enemies killed)

**Core/target:**
 
 - [ ] Swap health bar (swap out Health.cs with enemy health bar)

**Player:**
 - [ ] Add health (so enemies can damage the player)
	 - [ ] Add first person health bar

**Enemies:**
 - [ ] Add damage player feature (they currently follow the player but do no damage)
 - [ ] Add attack and damage core 

>**Longer-Term Ideas** (If time allows):
>- **Add bomb characters**: Add bomb character ([asset store](https://assetstore.unity.com/packages/3d/characters/3d-monster-bomb-145319)) to the level the player can explode to strategically do more damage
>- **Add sounds**: music, death sound effects, spell sound effects, etc...
>- **Add more crafting objects for different upgrades**: 
>- **Add more unique levels**

## Links:
- [Link to Shared Project](https://github.com/Noe235/CART315FinalProject)
- [Link to Project Media](link)

# Week 10: Iterative Prototype 4: 

![LevelProgress](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/LevelScene.png)

> Journal about the first stage of your prototyping process. What was your idea? What specific questions were you trying to answer (goals)? Was it a look/feel, role, or implementation prototype? What fidelity levels are you dealing with? What did you learn and what are the next steps?

### Last Weeks Accomplished Goals

 - [x] Find red asset for collectable GameObject to craft flamethrower (red plants/mushrooms/gems etc)
 - [x] Finish level/scene 
	 - [x] Add red collectable assets
 - [x] Update Core/target health to enemy health bar (swap out Health.cs for enemy health bar)
 - [x] Update Horde script to attack core

## Idea

#### Finish the Core Loop Foundation
**Objective:**
 Ensure that the player, enemies, and core interact as intended—everyone can receive damage, and enemies can target either the core or the player.
- Update scripts so the player, enemies, and core have health, and take damage.
- Add horde waves

**Design:**
- **Level Design:** Continue creating an aesthetic game level/environment with assets to support the horde waves.
	- Add assets to core gameplay placeholders
		- Red mushroom assets to collect in inventory to craft into flamethrower
		- Crafting table asset
- **UI**: Continue working on UI
	- Add to game over screen:
		- Integrate: score, save system, save system

### Design Values

#### Core Gameplay
- **Complete the foundational core loop:** 
	- Emphasize a specific satisfying core loop of collecting resources, crafting weapons, and defending the core against waves of enemies. 
		- Resource Collection & Crafting: 
			- Players gather resources (e.g., red mushrooms) during waves, which they will eventually use to upgrade weapons or spells.
		- Player, enemy, core interaction:
			- Enemies attack either to player or core
		- Wave defense: The player and the core must survive against progressively harder waves. 
		- UI
	
- **Level Design**:
	- Start working on a low poly game scene, which can be expanded upon later (i.e., more levels and/or more detail).
		- Add assets
			- Core, player, enemies
			- Crafting table
			- Environment/landscape

## Questions to Answer


### Was it a look/feel, role, or implementation prototype?
**Implementation prototype:** for implementing health script logic (changing Health.cs to us EnemyHealth.cs logic), and updated FollowingEnemy.cs to attack either core or player.

**Look/Feel**: from integrating the assets to start solid placeholders for the level,

### Fidelity Levels
**Mid-high fidelity design:** Although not fully polished, by creating a solid foundation for our level by figuring out assets and getting designing the level, I feel confident about our design going forward. 

**Mid implementation**: replacing scripts, setting up logic for wave spawning, health bars, UI. I'm getting better at this, but  always takes quite a bit of time, especially understanding script logic you haven't written. Overall, it's working but not totally optimized or polished and still has a ways to go (but it's getting there).

**Mid integration:**: Some systems (crafting, wave spawning, core health) are integrated, but UI scoring, saving, and final gameplay loop need more work.


## Accomplishments

### Designed Game Level with Assets

After playing around with the assets, I figured out how to convert them to Universal Render Pipeline. After I figured this, I found starting to design the level was really enjoyable, and adding the assets really brought everything to life. It's not finished, but it's a good start.

![LevelProgress2](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/Level.gif)

I added a bunch of red mushrooms to add to the inventory to use at the crafting station to visualize them and choose one to use. The dancing mushroom is my favourite.

![LevelProgress2](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/RedMushrooms.gif)

### Updated Horde (FollowingEnemy.cs) to attack either core or player
Enemies are now set up to target either the player or the core. 

The enemy script (FollowingEnemy.cs) previously only followed the  player. I updated the script to attack the player only or core only. Then I added a new prefab (CoreAttacker), and set it to attack the core (with Enemy.cs in inspector).

This way we can use the same script with two different prefabs, which are both easily added to the spawner (in inspect).

### Updated Core (CoreHealth.cs & added asset)
I added the Enemy.cs logic to make a new script especially for the core's health (CoreHealth.cs). Now the core has a health bar. It needs its own script since it calls the game over scene when it dies.

I replaced the cylinder placeholder with an asset too

![Core](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/GameOverCore.gif)

## What I Learned
To convert assets when they are hot pink: First, figure out which pipeline you are using. For example, I am using Universal Render Pipeline (URP). So first I make sure the asset is compatible with URP in the asset store. Then once it's imported (and hot pink): select the materials → edit → rendering → convert selected materials to URP. Then when you go to look at the models and prefabs, they will have the right material (instead of grayed out).

![Convert-to-URP](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/Convert-URP.png)

## Next Steps (Goals)

 - [ ] Add Wave Spawner to Spawner script 
	 - Wave 1, 2, 3...
	 - When last enemy dies → -   If enemies = 0 and get keydown i → then spawn next wave
 
**UI:**
 
 - [ ] Add save system
 - [ ] Add high score
 - [ ] Configure score UI working (so it updates with enemies killed)
 - [ ] Wave counter

**Player:**
 - [ ] Add health (so enemies can damage the player)
	 - [ ] Add first person health bar

**Enemies:**
 - [ ] Add damage player feature (they currently follow the player but do no damage)
 - [ ] Add attack and damage core 

**Continue Working on Level**:
 - [ ] Add Assets:
	 - [ ] Crafting table
	 - [ ] Sounds
	 - [ ] Replace player capsules with character assets

>**Longer-Term Ideas** (If time allows):
>- **Add bomb characters**: Add bomb character ([asset store](https://assetstore.unity.com/packages/3d/characters/3d-monster-bomb-145319)) to the level the player can explode to strategically do more damage
>- **Add sounds**: music, death sound effects, spell sound effects, etc...
>- **Add more crafting objects for different upgrades**: 
>- **Add more unique levels**


## Links:
- [Link to Shared Project](https://github.com/Noe235/CART315FinalProject)
- [Link to Project Media](https://github.com/xaynia/CART-315/tree/main/Process/Images/FinalProject)

# Week 11: Prototype Stage 4

![LevelGhosts](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/Level.png)

### Last Weeks Accomplished Goals
 - [x] Add Wave Spawner to Spawner script 
 -  [x] Update enviroment assets
	 - [x] Add fire powerups
	 - [x] Added ice powerups
	 - [x] Update enviroment
		 - [x] Fix clouds
		 - [x] Add cuboid animation 
			 - [x]  Fix cuboid (core) from floating away
 - [x] Enemies damage player  
	
**Enemies:**
 - [x] Add damage player feature (they currently follow the player but do no damage)
 - [x] Enemies: kill core

## Idea

### Finish Core loop:
Still working on the core loop, but shifting from implementation to refinement going forward.
### Our Core Loop Accomplishments: 
> Emphasize a specific satisfying core loop of collecting resources, crafting weapons, and defending the core against waves of enemies. 

 **Horde/Wave Defense**
 - [x] Added enemy wave spawner
 - [ ] Add to UI? (e.g.: Score (enemies killed), etc)

**Gathering/Resource Collection**
- [x]  Add assets for player gather during level and upgrade:
	- [x] Flamethrower upgrade: red mushrooms
	- [x] Ice spell: blue mushrooms, ice plants
- [x]   Inventory System

**Resource Gathering → Crafting → Weapon Upgrades:**
- [x] Implemented logic
- [ ] Test 

**Combat**
- [x] Attack:
	- [x] Enemies attack player and core 
	- [x] Player can attack enemies
	- [x] Player can swap spells with keys
- [x] Health: Enemies, player, and core have health and deal damage

### Design Values
**Level Design:**
- Choose aesthetic: 
	- [ ] Minimal design
	- [ ] Add more (add more levels? assets, spells, etc)

## Goals
- Prioritize and plan what we want (to add/remove/update) for the end result
- Test early
	- Stress test
- Refine
- Polish

## Questions to Answer

### Was it a look/feel, role, or implementation prototype?
**Implementation prototype:**
- Implementing the last of the core loop
### Fidelity Levels
**Mid-high fidelity design:** 
- Integrating mechanics
- Learning how to assign assets with animations as a character, and implement existing logic to it
- Lots of debugging while you figure this out

## Accomplishments
### Added Wave Spawner for Enemies
I updated the EnemySpawner.cs script to manage (spawn and track) enemy waves. 

It doesn't start right away, wen you press "I" it spawns the first wave (initially it spawns a wave of 10 enemies). Once the wave is defeated, the player can press "I" key to spawn the next wave which adds 10 more enemies than the previous wave (i.e., wave 2 spawns 20 enemies, wave 3 spawns 30 enemies, and so forth)

- Tracks current wave (`waveIndex`)
- - Boolean checks if a wave is spawning (yes/no) (`waveInProgress`)
- If no wave is spawning and enemiesAlive = 0, press "I" to start a new wave 
- `Spawnwave ( )` spawns wave number + waveIndex with wave count + additional enemies per wave

### Created ghost hordes

- Setup Enemy prefabs as ghost assets
- Made a new script for them
- Tested them
- Added them as prefab variants
	- They kill the player and the core
	- The player can kill them (updated projectile script)

![GhostHorde](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/GhostHorde.gif)

![GhostHorde](https://github.com/xaynia/CART-315/blob/main/Process/Images/FinalProject/Ghosts.png)

### Added Fire & Ice Area to Level
- Added fire and ice area and a bunch of different mushrooms to choose for to power up weapon

## What I Learned
- Use a sandbox to test assets
- Clear your unity cache

## Question to answers: 
**Wave defense: The player and the core must survive against progressively harder waves. How will this test?**
- Should we add a limited time the player can spawn a new wave (e.g.: 30 seconds) to limit resource gathering?
- Will gathering resources be too easy?
- How will the UI compliment the waves (high score, etc). Would anything else be useful to add?

**How to use Animator for characters:**

**Level Design:**
- Is the level too small? too cluttered with assets?
- Are the resources too easy to get? 
	- Are there too many? Should we have a short respawn window to make resources harder to get?
- Should we add more levels?


## Next Steps (Goals)

### Testing:
Now that the core logic has been implemented, stress testing the core loop ASAP to make sure everything runs smoothly (to debug, make adjustments, etc)
- [ ] **Test core loop:**
	- [ ] Stress test (many) enemy waves 
	- [ ] Test resource gathering & crafting:
		- [ ] Test inventory/gathering scripts
		- [ ] Test inventory/crafting/weapon scripts
	- [ ] Test player first person health bar (if it needs a health script, could use CoreHealth script)

**UI:**
 - [ ] Add save system
 - [ ] Add high score
 - [ ] Configure score UI working (so it updates with enemies killed)
 - [ ] Wave counter

### Level Ideas:
- [ ]  Add Sounds effects
	- [ ] Music
	- [ ] Element sounds (fire, ice)
	- [ ] Player sounds (attack, death)
- [ ] Add crafting table asset for crafting?
- [ ] Add flame/ice assets
 - [ ] Replace player capsules with character assets

>**Longer-Term Ideas** (If time allows):
>- [ ] **Add bomb characters**: Add bomb character ([asset store](https://assetstore.unity.com/packages/3d/characters/3d-monster-bomb-145319)) to the level the player can explode to strategically do more damage
>- [ ] **Add sounds**: music, death sound effects, spell sound effects, etc...
>- [ ]  **Add more crafting objects for different upgrades**: 
>- [ ] **Add another level** (depends on need)

## Links:
- [Link to Project](link)
- [Link to Project Media](https://github.com/xaynia/CART-315/tree/main/Process/Images/FinalProject)

