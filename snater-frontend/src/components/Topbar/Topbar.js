import React from "react";
import "./topbar.scss";

export default function Topbar() {
  return (
    <div className="topbarContainer">
      <ProfileContainer />
      <FriendOptionsContainer />
      {/* <hr /> */}
    </div>
  );
}

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

function FriendOptionsContainer() {
  return (
    <div className="friendOptionsContainer">
      <div>
        <p>Friends</p>
      </div>
      <div>
        <p>Online</p>
      </div>
      <div>
        <p>All</p>
      </div>
      <div>
        <p>Pending</p>
      </div>
      <div>
        <p>Blocked</p>
      </div>
      <div>
        <button type="button">Add Friend</button>
      </div>
    </div>
  );
}
