import React, { useState, useRef } from "react";
import "./app.scss";

function App() {
  return (
    <div className="leftSelectContainer">
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

      <hr />

      <div className="searchbarContainer">
        <input
          type="text"
          name="conversationSearch"
          placeholder="Find or start a conversation"
        ></input>
      </div>

      <hr />

      <div className="friendButtonContainer">
        <button className="friendButton">Friends</button>
      </div>

      <hr />

      <div className="openChatContainer">
        <div className="openChatButton">
          <div className="userProfilePicture">
            <img
              src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/User-avatar.svg/1024px-User-avatar.svg.png"
              alt="UserProfile"
            ></img>
          </div>
          <div className="usernameText">
            <div>
              <p className="username">Henk</p>
            </div>
            <div>
              <p className="userStatus">Hello my name is name</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;
