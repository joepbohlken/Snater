import React from "react";
import "./app.scss";

import Sidebar from "./components/Sidebar/Sidebar";
import FriendsContent from "./components/FriendsContent/FriendsContent";
import Topbar from "./components/Topbar/Topbar";

function App() {
  return (
    <div>
      <Topbar />
      <Sidebar />
      <FriendsContent />
    </div>
  );
}

export default App;
