import React from "react";
import "./app.scss";

import Sidebar from "./components/Sidebar";
import FriendsContent from "./components/FriendsContent";

function App() {
  return (
    <div>
      <Sidebar />
      <FriendsContent />
    </div>
  );
}

export default App;
