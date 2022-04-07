import React from "react";

export default function LeftSelectContainer() {
  return (
    <div className="leftSelectContainer">
      <ProfileContainer />
      <hr />
      <SearchbarContainer />
      <hr />
      <FriendButtonContainer />
      <hr />
      <OpenChatContainer />
    </div>
  );

  function ProfileContainer() {
    const user = {
      username: "Firefromass",
      tag: "7011",
      status: "online",
    };
    return (
      <div className="profileContainer">
        <div className="profilePicture">
          <img
            src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/User-avatar.svg/1024px-User-avatar.svg.png"
            alt="UserProfile"
          ></img>
          <div className={`userStatus ${user.status}`} />
        </div>
        <div className="usernameText">
          <div>
            <p className="username">{user.username}</p>
          </div>
          <div>
            <p className="userTag">#{user.tag}</p>
          </div>
        </div>
        <div className="settingsIcon">
          <i className="fa-solid fa-ellipsis-vertical"></i>
        </div>
      </div>
    );
  }

  function SearchbarContainer() {
    return (
      <div className="searchbarContainer">
        <input
          type="text"
          name="conversationSearch"
          placeholder="Find or start a conversation"
        ></input>
      </div>
    );
  }

  function FriendButtonContainer() {
    return (
      <div className="friendButtonContainer">
        <button className="friendButton">Friends</button>
      </div>
    );
  }

  function OpenChatContainer() {
    const chats = [
      {
        username: "henk",
        lastMessage: "hello how is your day",
        lastMessageTime: "13:06",
        userStatus: "online",
      },
      {
        username: "pieter",
        lastMessage: "Wat ga jij vandaag doen?aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
        lastMessageTime: "12:17",
        userStatus: "offline",
      },
      {
        username: "yuran",
        lastMessage: "Gefelicteerd Joep",
        lastMessageTime: "12:08",
        status: "dontDisturb",
      },
    ];
    return (
      <div className="openChatContainer">
        {chats.map((chat) => (
          <div className="openChatButton">
            <div className="userProfilePicture">
              <img
                src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/User-avatar.svg/1024px-User-avatar.svg.png"
                alt="UserProfile"
              ></img>
              <div className={`userStatus ${chat.userStatus}`} />
            </div>
            <div className="usernameText">
              <div>
                <p className="username">{chat.username}</p>
              </div>
              <div>
                <p className="userLastMessage">{chat.lastMessage}</p>
              </div>
              <div>
                <p className="userLastMessageTime">{chat.lastMessageTime}</p>
              </div>
            </div>
          </div>
        ))}
      </div>
    );
  }
}
