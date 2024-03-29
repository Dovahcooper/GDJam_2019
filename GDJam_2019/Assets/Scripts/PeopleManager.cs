﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleManager : MonoBehaviour
{
    string[] dialogue;

    public Person[] people = new Person[10];

    // Start is called before the first frame update
    void Start()
    {
        //put all the dialogue options here
        //please god, do it.
        dialogue = new string[(int)Items.maxItems]{
            "Oh, my cake is here! I’ve been waiting for this replacement since they sent me the strawberry one last week.",
            "Oh perfect, a package! I hope this is the generator I ordered; I haven’t had power all week.",
            "Sorry, I’d grab the package from you, but my hands are all blistered. I just put together a bookshelf. It’s so annoying having to twist in all the screws by hand. I wish there was an easier way.",
            "Hail Page! What delivery dost thou have for me today? Oh sorry man, was just at a renaissance fair last night. I was going to be a knight, but couldn’t find my sword.",
            "A package? For me? I’m so glad! It must be a present for the tap recital I had last night. But boy do my feet hurt, I couldn’t find my tap shoes so I just stepped down hard and hoped nobody noticed.",
            "A package for me? In a cardboard box? Don’t you know those are bad for the environment? I’ve gone paperless recently to help #SaveTheTurtles. Me and my Hydro Flask are going back inside now.",
            "Oh, look at that timing. I just got back from a buffet! A few minutes earlier and you wouldn’t have caught me. I wonder what could be in this package?",
            "I wonder if this is the new instrument my music teacher wanted me to try. I tried playing guitar, but uh, my hands are scissors and they kept cutting the strings.",
            "Good thing you got here after sunset, otherwise I wouldn’t have been able to come out to get it. Gotta love being unable to set foot outside in the sun without turning to ash.",
            "This must be my venus flytrap! I’ve been wanting some company but I’m horribly allergic to pets, so I figured this little guy was the next best thing.",
            "Dude, you wouldn’t believe what happened to me. I was in the mines last night, and I came across some great diamonds. So, I kept punching at the rock to get them out, but they wouldn’t budge! Can you believe that? I came back empty-handed. Anyways, thanks for the package man.",
            "Oh, thanks for the package. Mrs. Potato Head thinks I’ve been seeing another spud, so hopefully these are the flowers I ordered for her.",
            "Why hello there. This must be the list of all the nice children that the elves wanted to send me. I do hope you’re on that list, Ho Ho Ho!",
            "What’s this? Just put the package down next to the giant flame eyeball. I’ve got to instruct the Orcs on a battle plan.",
            "You are the first person I’ve talked to in days. I’ve been trying to debug this program I’ve been working on, and I just got it done. I figure social interaction is good, so thanks for dropping by, even if it’s just your job.",
            "I’m glad this package was able to make it to me! I just moved out of my two-storey home into this nice cozy one-storey house."
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Person NextPerson(ref int currentPerson)
    {
        return people[currentPerson++];
    }
}
