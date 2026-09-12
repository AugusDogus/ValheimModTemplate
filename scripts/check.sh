#!/usr/bin/env bash
set -euo pipefail
cd "$(dirname "$0")/.."

# Add game-independent behavior and compatibility checks as the mod grows.
python3 scripts/validate-package.py
