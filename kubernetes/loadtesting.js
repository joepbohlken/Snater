import http from "k6/http";
import { check, fail } from "k6";

export let options = {
  insecureSkipTLSVerify: true,
  noConnectionReuse: false,
  vus: 10,
  duration: "30s",
  thresholds: {
    http_req_duration: ["p(99)<150"], // 99% of requests must complete below 150ms
  },
};

export default () => {

  const res = http.get(`http://localhost:5000/weatherforecast`);

  const checkOutput = check(res, { "status was 200": (r) => r.status == 200 });

  if (!checkOutput) {
    fail("unexpected response");
  }
};
