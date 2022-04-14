import axios from "axios";
import moment from "moment";
import React, { useEffect, useState } from "react";
import "./sidebar.scss";

export default function LeftSelectContainer() {
  return (
    <div className="leftSelectContainer">
      <SearchbarContainer />
      <hr />
      <FriendButtonContainer />
      <hr />
      <OpenChatContainer />
    </div>
  );

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
    const [chats, setChats] = useState([]);

    async function GetChats() {
      return await axios
        .get("https://localhost:5020/api/User")
        .then((response) => {
          console.log(response);

          setChats(response.data.chats);
        });
    }
    useEffect(() => {
      GetChats();
    }, []);

    function getStatus(status) {
      switch (status) {
        case 0:
          return "offline";
        case 1:
          return "online";
        case 2:
          return "away";
        case 3:
          return "dontDisturb";
        default:
          return "";
      }
    }
    return (
      <div className="openChatContainer">
        {chats.map((chat) => (
          <div className="openChatButton">
            <div className="userProfilePicture">
              <img
                src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/User-avatar.svg/1024px-User-avatar.svg.png"
                alt="UserProfile"
              ></img>
              <div className={`userStatus ${getStatus(chat.user.status)}`} />
            </div>
            <div className="usernameText">
              <div>
                <p className="username">{chat.user.username}</p>
              </div>
              <div>
                <p className="userLastMessage">{chat.lastMessage}</p>
              </div>
              <div>
                <p className="userLastMessageTime">
                  {moment(chat.lastMessageTime).format("HH:m")}
                </p>
              </div>
            </div>
          </div>
        ))}
      </div>
    );
  }
}
