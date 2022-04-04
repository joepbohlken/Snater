import React from "react";

function ProfileContainer() {
  return (
    <div className="profileContainer">
      <div className="profilePicture">
        <img
          src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/User-avatar.svg/1024px-User-avatar.svg.png"
          alt="UserProfile"
        ></img>
      </div>
      <div className="usernameText">
        <div>
          <p className="username">Username</p>
        </div>
        <div>
          <p className="userTag">#0000</p>
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
  const chats = [{ username: "henk", lastMessage: "hello how is your day" }];
  return (
    <div className="openChatContainer">
      {chats.map((chat) => (
        <div className="openChatButton">
          <div className="userProfilePicture">
            <img
              src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/User-avatar.svg/1024px-User-avatar.svg.png"
              alt="UserProfile"
            ></img>
          </div>
          <div className="usernameText">
            <div>
              <p className="username">{chat.username}</p>
            </div>
            <div>
              <p className="userStatus">{chat.lastMessage}</p>
            </div>
          </div>
        </div>
      ))}
    </div>
  );
}

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
}
